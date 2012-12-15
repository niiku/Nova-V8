using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class Project
    {
        public int id { get; set; }
        public int customer;
        public string number { get; set; }
        public DateTime begin { get; set; }
        public int active { get; set; }
        public string name { get; set; }

        public Customer Kunde()
        {
            throw new NotImplementedException();
        }

        public List<Task> Aufgaben()
        {
            throw new NotImplementedException();
        }
    }
}
