using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Customer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Beschreibung { get; set; }

        public List<Project> Projekte()
        {
            throw new NotImplementedException();
        }
    }
}
