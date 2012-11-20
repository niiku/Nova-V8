using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Rapport
    {
        int Id { get; set; }
        DateTime Datum { get; set; }
        float Aufwand { get; set; }
        int BenutzerId { get; set; }
        int AufgabenId { get; set; }

        public Aufgabe Aufgabe()
        {
            throw new NotImplementedException();
        }

        public Benutzer Benutzer()
        {
            throw new NotImplementedException();
        }
    }
}
