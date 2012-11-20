using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Aufgabe
    {
        int Id { get; set; }
        int ProjektId;
        string Name { get; set; }
        string Beschreibung { get; set; }

        public Projekt Projekt()
        {
            throw new NotImplementedException();
        }

        public List<Rapport> Rapporte()
        {
            throw new NotImplementedException();
        }
    }
}
