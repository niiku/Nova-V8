using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class User
    {
        int id { get; set; }
        string name { get; set; }
        string password { get; set; }
        int profile { get; set; }

        public Profile Profile()
        {
            return Simplifier.findById<Profile>(profile);

        }
    }
}
