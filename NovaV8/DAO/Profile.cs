using System;
using System.Collections.Generic;
using System.Text;


namespace NovaV8
{
    public class Profile
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Component> Components()
        {
            return Simplifier.Query<Component>("SELECT c.* FROM Permission as p " +
"JOIN component as c on p.component = c.id " +
"JOIN profile as pr on p.profile = pr.id " +
"WHERE pr.id = " + id + ";");

        }

        public void setComponent(Component c)
        {
            List<Permission> pList = PermissionService.FindPermissionByComponentAndProfile(c, this);
            if (pList.Count > 0)
            {
                Permission p = pList[0];
                p.component = c.id;
                p.profile = id;
                Simplifier.update(p);
            }
            else
            {
                Permission newP = new Permission();
                newP.component = c.id;
                newP.profile = id;
                Simplifier.insert(newP);
            }

        }

        public void removeComponent(Component c)
        {
            List<Permission> pList = PermissionService.FindPermissionByComponentAndProfile(c, this);
            if (pList.Count > 0)
            {
                Permission p = pList[0];
                Simplifier.delete(p);
            }
        }
    }
}
