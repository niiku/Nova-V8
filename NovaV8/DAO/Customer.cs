using System;
using System.Collections.Generic;
using System.Text;


namespace NovaV8
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public List<Project> Projects()
        {
            return ProjectService.FindProjectsByCustomer(this);
        }
    }
}
