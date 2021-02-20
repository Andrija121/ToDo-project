using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject
{
    class Tasks
    {
        private static List<string> tasks = new List<string>();
        private static List<string> doneTasks = new List<string>();


        public List<string> AddTask(string task)
        {
            tasks.Add(task);
            return tasks;
        }
        public void DeleteTask(int index)
        {
            tasks.RemoveAt(index);
        }
        public void ChangeTask(int index, string task)
        {
            tasks[index] = task;
        }
        public void CompleteTask(int index)
        {
            List<string> doneTasks = new List<string>();
            foreach (var task in tasks)
            {
                tasks.AddRange(doneTasks);
            }
            
        }
        public List<string> GetTasks()
        {
            return tasks;
        }
      /*  public string GetTask(string task)
        {
            return task;

        }      */
    }

}
