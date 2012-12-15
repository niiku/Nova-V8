using System;
using System.Collections.Generic;
using System.Text;

namespace NovaV8
{
    public class Report
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int expenditure { get; set; }
        int user { get; set; }
        int task { get; set; }

        public Task Task()
        {
            return Simplifier.findById<Task>(task);
        }

        public User User()
        {
            return Simplifier.findById<User>(user);
        }
    }
}
