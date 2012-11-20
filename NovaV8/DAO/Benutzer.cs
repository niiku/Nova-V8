using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Benutzer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Passwort { set; }
        int ProfilId;

        public Profil Profil()
        {
            throw new NotImplementedException();
        }

        public string PasswortHash()
        {
            throw new NotImplementedException();
        }
    }
}
