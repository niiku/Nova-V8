﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace NovaV8
{
    public class DBConnector
    {
        private String server = ConfigurationManager.AppSettings.Get("host");
        private String database = ConfigurationManager.AppSettings.Get("database");
        private String user = ConfigurationManager.AppSettings.Get("user");
        private String password = ConfigurationManager.AppSettings.Get("password");

        String connectionString;

        MySqlConnection connection = null;

        private static DBConnector instance;

        private DBConnector()
        {
            this.connectionString = "SERVER=" + this.server + ";DATABASE=" + this.database + ";UID=" + this.user + ";PASSWORD=" + this.password + ";";
        }

        public static DBConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnector();
                }
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (this.connection == null)
                {
                    this.connection = new MySqlConnection(this.connectionString);
                }
                return this.connection;
            }
            catch (MySqlException e)
            {
                throw new DatabaseException("Error connecting Database {0}", e);
            }
        }

    }
}
