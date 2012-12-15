using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.DAO
{
    public class Project
    {
        int Id { get; set; }
        int KundenId;
        string Nummer { get; set; }
        DateTime Beginn { get; set; }
        int Aktiv { get; set; }
        string Name { get; set; }

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
