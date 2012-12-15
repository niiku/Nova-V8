using System;
using System.Collections.Generic;
using System.Text;
namespace NovaV8
{
    public class ProjectService
    {
        public static List<Project> FindProjectsByCustomer(Customer customer)
        {
                return Simplifier.Query<Project>("SELECT * FROM PROJECT WHERE CUSTOMER = "+customer.id+";");
        }

        public static Project FindById<Project>(long id)
        {
            return Simplifier.findById<Project>(id);
        }
    }
}
