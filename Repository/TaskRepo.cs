
using APIDemo.Models;

namespace APIDemo.Repository
{
    public class TaskRepo : ITaskRepo
    {

        List<MyTask> Tasks = new List<MyTask>()
        {
            new MyTask{Id=1,Name="task1"},
            new MyTask{Id=2,Name="task2"}
        };
        public async Task AddTask(MyTask t)
        {
            Tasks.Add(t);
        }

        public async Task DeleteTask(int id)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Id == id) { 
                    Tasks.RemoveAt(i);
                }
            }
        }
        public async Task UpdateTask(MyTask t)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Id == t.Id)
                {
                    Tasks[i].Name = t.Name;
                    break;
                   
                }
            }
        }

        public async Task<IEnumerable<MyTask>> GetTask()
        {
            List<MyTask> t1 = new List<MyTask>();
            foreach (MyTask item in Tasks)
            {
               t1.Add(item);

            }
            return t1;
        }

       
    }
}

