using System;
using System.Collections.Generic;
using System.Text;
namespace NovaV8

{
    public class UserService
    {
        public static User FindById<User>(long id)
        {
            return Simplifier.findById<User>(id);
        }
        public static List<User> FindAll()
        {
            return Simplifier.FindAll<User>();
        }

        public static User FindUserByName(string name) {
            List<User> users = Simplifier.Query<User>("SELECT * FROM USER WHERE NAME LIKE '"+name+"'");
            if(users.Count > 0) {
                return users[0];
            }
            return null;
        }
    }
}
