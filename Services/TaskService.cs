using APIDemo.Models;
using APIDemo.Repository;
using System.Runtime.CompilerServices;

namespace APIDemo.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepo taskRepo;
        public TaskService(ITaskRepo taskRepo)
        {
                this.taskRepo=taskRepo;
        }
        public Task AddTask(MyTask t)
        {
           return taskRepo.AddTask(t);  
        }

        public Task DeleteTask(int id)
        {
           return taskRepo.DeleteTask(id);
        }

        public Task<IEnumerable<MyTask>> GetTask()
        {
            return taskRepo.GetTask();
        }

        public Task UpdateTask(MyTask t)
        {
            return taskRepo.UpdateTask(t);
        }
    }
}
