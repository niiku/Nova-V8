using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.DAO
{
    public class Report
    {
        int Id { get; set; }
        DateTime Datum { get; set; }
        float Aufwand { get; set; }
        int BenutzerId { get; set; }
        int AufgabenId { get; set; }

        public Task Aufgabe()
        {
            throw new NotImplementedException();
        }

        public User Benutzer()
        {
            throw new NotImplementedException();
        }
    }
}
