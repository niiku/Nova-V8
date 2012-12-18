using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class Component
    {
        public int id { get; set; }
        public string name { get; set; }

        public override String ToString()
        {
            return name;
        }
    }
}
