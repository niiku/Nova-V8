using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaV8.Service
{
    class ProfileService
    {
        public static Profile FindById<Profile>(long id)
        {
            return Simplifier.findById<Profile>(id);
        }
        public static List<Profile> FindAll()
        {
            return Simplifier.FindAll<Profile>();
        }
    }
}
