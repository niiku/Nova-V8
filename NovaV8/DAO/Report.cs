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
        public int user { get; set; }
        public int task { get; set; }
        public int project { get; set; }
        public String description { get; set; }
        public Task Task()
        {
            return Simplifier.findById<Task>(task);
        }

        public User User()
        {
            return Simplifier.findById<User>(user);
        }

        public Project Project()
        {
            return Simplifier.findById<Project>(project);
        }

        public void setProject(Project project)
        {
            this.project = project.id;
            Simplifier.insertOrUpdate(project);
        }

        public void setTask(Task task)
        {
            this.task = task.id;
            Simplifier.insertOrUpdate(task);
        }

        public void setUser(User user)
        {

            this.user = user.id;

            Simplifier.insertOrUpdate(user);
        }
    }
}
