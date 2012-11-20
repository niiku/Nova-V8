using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Projekt
    {
        int Id { get; set; }
        int KundenId;
        string Nummer { get; set; }
        DateTime Beginn { get; set; }
        int Aktiv { get; set; }
        string Name { get; set; }

        public Kunde Kunde()
        {
            throw new NotImplementedException();
        }

        public List<Aufgabe> Aufgaben()
        {
            throw new NotImplementedException();
        }
    }
}
