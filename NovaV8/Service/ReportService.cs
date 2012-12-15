using System;
using System.Collections.Generic;
using System.Text;
namespace NovaV8
{
    public class ReportService
    {
        public static List<Report> FindReportsByProject(Project project) {
        return Simplifier.Query<Report>("SELECT * FROM REPORT WHERE PROJECT = "+project.id+";");
}
        public static Report FindById<Report>(long id)
        {
            return Simplifier.findById<Report>(id);
        }

        public static List<Report> FindAll()
        {
            return Simplifier.FindAll<Report>();
        }

        internal static List<Report> FindReportsByUser(User user)
        {
            return Simplifier.Query<Report>("SELECT * FROM REPORT WHERE user =" + user.id + ";");
        }
    }
   
}
