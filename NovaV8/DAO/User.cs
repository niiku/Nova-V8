using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.DAO
{
    public class User
    {
        int Id { get; set; }
        string Name { get; set; }
        string Passwort { set; }
        int ProfilId;

        public Profile Profil()
        {
            throw new NotImplementedException();
        }

        public string PasswortHash()
        {
            throw new NotImplementedException();
        }
    }
}
