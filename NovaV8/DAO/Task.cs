using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8.Modelle
{
    public class Task
    {
        int Id { get; set; }
        int ProjektId;
        string Name { get; set; }
        string Beschreibung { get; set; }

        public Project Projekt()
        {
            throw new NotImplementedException();
        }

        public List<Report> Rapporte()
        {
            throw new NotImplementedException();
        }
    }
}
