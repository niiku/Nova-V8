using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaV8
{
    public class PermissionService
    {
        public static List<Permission> FindPermissionByComponentAndProfile(Component c, Profile p)
        {
            return Simplifier.Query<Permission>("SELECT * FROM Permission WHERE component = " + c.id + " AND profile = " + p.id);
        }
    }
}
