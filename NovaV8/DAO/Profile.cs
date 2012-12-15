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
            return Simplifier.Query<Component>("SELECT c.* FROM Permission as p" +
"JOIN component as c on p.component = c.id" +
"JOIN profile as pr on p.profile = pr.id" +
"WHERE pr.id = " + id + ";");

        }
    }
}
