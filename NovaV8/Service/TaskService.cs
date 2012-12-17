using System;
using System.Collections.Generic;
using System.Text;
namespace NovaV8
{
    public class TaskService
    {
        public static List<Task> FindAll()
        {
            return Simplifier.FindAll<Task>();
        }
        public static Task FindById<Task>(long id)
        {
            return Simplifier.findById<Task>(id);
        }

    }
}