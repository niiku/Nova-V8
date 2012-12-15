using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int profile { get; set; }

        public Profile Profile()
        {
            return Simplifier.findById<Profile>(profile);

        }

        public List<Report> Reports()
        {
            return ReportService.FindReportsByUser(this);
        }


    }
}
