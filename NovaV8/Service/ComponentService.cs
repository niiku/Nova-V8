using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaV8
{
    public class ComponentService
    {
        public static List<Component> FindAll()
        {
            return Simplifier.FindAll<Component>();
        }

        public static Component FindById(int id)
        {
            return Simplifier.findById<Component>(id);
        }
    }
}
