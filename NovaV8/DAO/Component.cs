using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class Component
    {
        public static int ADD_USER = 1;
        public static int EDIT_USER = 2;
        public static int ADD_REPORT = 3;
        public static int EDIT_REPORT = 4;
        public static int ADD_CUSTOMER = 5;
        public static int EDIT_CUSTOMER = 6;
        public static int ADD_TASK = 7;
        public static int EDIT_TASK = 8;
        public static int ADD_PERMISSION = 9;
        public static int EDIT_PERMISSION = 10;
        public static int SHOW_STAMMDATEN = 11;

        public int id { get; set; }
        public string name { get; set; }

        public override String ToString()
        {
            return name;
        }
    }
}
