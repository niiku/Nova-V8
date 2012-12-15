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
    }
}
