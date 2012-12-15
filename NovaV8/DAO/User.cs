using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace NovaV8
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { set; private get; }
        public int profile { get; set; }

        public Profile Profile()
        {
            return Simplifier.findById<Profile>(profile);

        }

        public List<Report> Reports()
        {
            return ReportService.FindReportsByUser(this);
        }

        public bool hasPermissionForComponent(long id)
        {
            foreach (Component c in Profile().Components())
            {
                if (c.id == id)
                {
                    return true;
                }
            }
            return false;

        }


        public bool rightPassword(string password)
        {
            return this.password.Equals(Utils.GetMD5Hash(password));
        }

    }
}
