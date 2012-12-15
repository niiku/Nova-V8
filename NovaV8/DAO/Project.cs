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

        public Customer Customer()
        {
            return Simplifier.findById<Customer>(customer);
        }

        public List<Report> Reports()
        {
            return ReportService.FindReportsByProject(this);
        }

        public void addReport(Report report)
        {

            Simplifier.insertOrUpdate(this);
            report.project = this.id;
            Simplifier.insertOrUpdate(report);
        }   
    }
}
