using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace NovaV8
{
    /// <summary>
    /// This class abstracts the Database and converts relational mapped datasets into c# objects.
    /// The models must be declared to represent the data structure
    /// </summary>
    public static class Simplifier
    {
        /// <summary>
        /// Returns each dataset of a given modeltype
        /// </summary>
        /// <typeparam name="T">Represents the modeltype</typeparam>
        /// <returns>Typed list of all datasets found</returns>
        public static List<T> FindAll<T>()
        {
            String query = "SELECT * FROM " + typeof(T).Name;
            try
            {
                return Query<T>(query);
            }
            catch
            {
                return default(List<T>);
            }
        }
         /// <summary>
         /// Method to execute queries on the database (DDL)
         /// </summary>
         /// <param name="sql">Query string</param>
         /// <returns>Returns the number of rows affected</returns>
        public static int Exec(String sql)
        {
            Console.WriteLine(sql);
            int count = 0;
            //Check if the connection is open
            if (DBConnector.Instance.GetConnection().State != System.Data.ConnectionState.Open)
            {
                //Open connection
                DBConnector.Instance.GetConnection().Open();
            }
            //Create command
            MySqlCommand command = DBConnector.Instance.GetConnection().CreateCommand();
            //Beginn transaction
            MySqlTransaction trans = DBConnector.Instance.GetConnection().BeginTransaction();
            command.Connection = DBConnector.Instance.GetConnection();
            command.Transaction = trans;
            try
            {
                command.CommandText = sql;
                //Check if its an insert statement
                if (sql.Substring(0, 6).ToUpper().Equals("INSERT"))
                {
                    //Returns the last inserted id
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                else
                {
                    //Execute a normal query
                    count = command.ExecuteNonQuery();
                }
                //Commit
                trans.Commit();
            }
            catch
            {
                try
                {
                    //Try to rollback in case of failure
                    trans.Rollback();
                }
                catch (MySqlException ex)
                {
                    throw new DatabaseException("Error in Rollback {0}", ex);
                }
                finally
                {
                    //Close the connection in each case
                    DBConnector.Instance.GetConnection().Close();
                }
            }
            finally
            {
                DBConnector.Instance.GetConnection().Close();
            }
            return count;
        }
        /// <summary>
        /// Method to make a query for getting datasets
        /// </summary>
        /// <typeparam name="T">Represents the modeltype</typeparam>
        /// <param name="query">Querystring</param>
        /// <returns>Typed list of each dataset found</returns>
        public static List<T> Query<T>(String query)
        {
            Console.WriteLine(query);
            MySqlDataReader reader = null;
            //Check if connection is already open
            if (DBConnector.Instance.GetConnection().State != System.Data.ConnectionState.Open)
            {
                //Open connection
                DBConnector.Instance.GetConnection().Open();
            }
            //Create new mysql command
            MySqlCommand command = new MySqlCommand(query, DBConnector.Instance.GetConnection());
            List<T> resultSet = new List<T>();
            try
            {
                //Query database
                reader = command.ExecuteReader();
                //Iterate over the reader
                while (reader.Read())
                {
                    //Make object with each result
                    resultSet.Add(CreateObject<T>(reader));
                }
            }
            catch (Exception e)
            {
                throw new DatabaseException("Error query: \"" + query + "\" - {1}", e);
            }
            finally
            {
                if (reader != null)
                {
                    //Close the reader
                    reader.Close();
                }
                //Close the connection
                DBConnector.Instance.GetConnection().Close();
            }
            //Check if there is a result
            return resultSet;
        }

        /// <summary>
        /// Method to get one result by id
        /// </summary>
        /// <typeparam name="T">Represents the modeltype</typeparam>
        /// <param name="id">ID</param>
        /// <returns>Single object of result found with id given</returns>
        public static T findById<T>(Int64 id)
        {
            String query = "SELECT * FROM " + typeof(T).Name + " WHERE id = " + id;
            try
            {
                //Query database and get the first element
                return Query<T>(query).ElementAt(0);
            }
            catch
            {
                //Return null
                return default(T);
            }

        }

        /// <summary>
        /// Method to insert an object
        /// </summary>
        /// <param name="obj">Object to insert</param>
        public static void insert(Object obj)
        {
            //Get all properties of object
            PropertyInfo[] fields = obj.GetType().GetProperties();
            String[] paramInfo = new String[fields.Length];
            String[] paramValue = new String[fields.Length];
            //Get object type
            String tableName = obj.GetType().Name;
            //Prepare insert query
            String query = "INSERT INTO " + tableName + "(";
            char[] comma = new char[1] {','};
            int c = 0;
            //Iterate over each property
            foreach (PropertyInfo field in fields)
            {
                //Extract the param name
                paramInfo[c] = field.Name.ToString();
                //Extract the param value
                paramValue[c] = "'" + field.GetValue(obj).ToString() + "'";
                c++;
            }
            //Fill insert query with values
            query += String.Join(",", paramInfo).TrimEnd(comma) + ") VALUES(" + String.Join(",",paramValue).TrimEnd(comma) + ");";
            //Returns the last inserted id
            query += "SELECT LAST_INSERT_ID();";
            //Execute the query
            int lastId = Exec(query);
            //Set the new id
            obj.GetType().GetProperty("id").SetValue(obj, lastId);
        }

        public static void insert(List<Object> objList)
        {
            if (objList.Count > 0)
            {
                Object obj = objList.ElementAt(0);
                PropertyInfo[] fields = obj.GetType().GetProperties();
                String[] paramInfo = new String[fields.Length];
                String tableName = obj.GetType().Name;
                int c = 0;
                foreach (PropertyInfo field in fields)
                {
                    paramInfo[c] = field.Name.ToString();
                    c++;
                }
                String query = "INSERT INTO " + tableName + "(";
                char[] comma = new char[1] { ',' };
                query += String.Join(",", paramInfo).TrimEnd(comma) + ") VALUES";
                foreach (Object objInsert in objList)
                {
                    String[] paramValue = new String[fields.Length];
                    int count = 0;
                    foreach(PropertyInfo field in fields){
                        paramValue[count] = field.GetValue(objInsert).ToString();
                        count++;
                    }
                    query += "('" + String.Join("','", paramValue).TrimEnd(comma) + "'),";
                }
                query = query.Substring(0, query.Length - 1);
                Exec(query);
            }
        }

        /// <summary>
        /// Check if the object is already persisted.
        /// </summary>
        /// <param name="obj">Object to insert or update</param>
        public static void insertOrUpdate(Object obj)
        {
            try
            {
                //Get findById method
                MethodInfo findById = typeof(Simplifier).GetMethod("findById");
                //Make method gengeric
                MethodInfo genericFindById = findById.MakeGenericMethod(obj.GetType());
                //Get id of object
                Object[] queryParams = new Object[1] { obj.GetType().GetProperty("id").GetValue(obj) };
                //Try to find the object in database
                Object returnValue = genericFindById.Invoke(null, queryParams);
                //Check if the object was found
                if (returnValue != null)
                {
                    Simplifier.update(obj);
                }
                else
                {
                    Simplifier.insert(obj);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Method to delete an object
        /// </summary>
        /// <param name="obj">Object to delete</param>
        /// <returns>Number of rows affected</returns>
        public static int delete(Object obj)
        {
            //Get Table name
            String tableName = obj.GetType().Name;
            //Prepare delete query
            String query = "DELETE FROM " + tableName + " WHERE id = " + obj.GetType().GetProperty("id").GetValue(obj).ToString();
            //Execute query
            return Exec(query);
        }

        /// <summary>
        /// Method to update an object
        /// </summary>
        /// <param name="obj">Object to update</param>
        /// <returns>Number of rows affected</returns>
        public static int update(Object obj)
        {
            PropertyInfo[] fields = obj.GetType().GetProperties();
            String[] paramValue = new String[fields.Length];
            String id = obj.GetType().GetProperty("id").GetValue(obj).ToString();
            String tableName = obj.GetType().Name;
            String query = "UPDATE " + tableName + " SET ";
            char[] comma = new char[1] { ',' };
            int c = 0;
            foreach (PropertyInfo field in fields)
            {
                if(c != 0){
                   query += field.Name.ToString() + "='" + field.GetValue(obj).ToString() + "',";
                }
                c++;
            }
            query = query.Substring(0, query.Length - 1);
            query += " WHERE id = " + id;
            return Exec(query);
        }

        /// <summary>
        /// Method to create an object defined as a model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static T CreateObject<T>(MySqlDataReader reader) {
            PropertyInfo[] fields = typeof(T).GetProperties();
            T instance = Activator.CreateInstance<T>();
            foreach (PropertyInfo field in fields)
            {
                Type fieldType = field.PropertyType;
                if(fieldType.IsFrameworkType()){
                    typeof(T).GetProperty(field.Name).SetValue(instance, Convert.ChangeType(reader[field.Name], field.PropertyType));
                }/*else {
                    Type genericListType = typeof(List<>);
                    Type specificListType = genericListType.MakeGenericType(fieldType);
                    Object list = Activator.CreateInstance(specificListType);
                    MethodInfo method = typeof(Simplifier).GetMethod("FindAll");
                    MethodInfo generic = method.MakeGenericMethod(fieldType);
                    String query = "SELECT * FROM " + field.PropertyType.ToString().ToLower() + " WHERE id = " + reader[fieldType.Name];
                    Object[] queryParams = new Object[1] {query};
                    list = generic.Invoke(null, queryParams);
                    Object[] elementAtParams = new Object[2] { list, 0 };
                    MethodInfo mInfo = typeof(System.Linq.Enumerable).GetMethod("ElementAt", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy).MakeGenericMethod(fieldType);
                    Object firstElement = mInfo.Invoke(null, elementAtParams);
                    typeof(T).GetProperty(field.Name).SetValue(instance, firstElement);
                }*/
            }
            return instance;
        }

    }
}
