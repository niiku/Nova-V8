using System;
using System.Collections.Generic;
using System.Text;


namespace NovaV8
{
    public class Task
    {
        public int id { get; set; }
        public int project;
        public string name { get; set; }
        public string description { get; set; }

        public override String ToString()
        {
            return name;
        }
    }
}
