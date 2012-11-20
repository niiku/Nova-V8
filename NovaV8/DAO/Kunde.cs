using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Kunde
    {
        int Id { get; set; }
        string Name { get; set; }
        string Beschreibung { get; set; }

        public List<Projekt> Projekte()
        {
            throw new NotImplementedException();
        }
    }
}
