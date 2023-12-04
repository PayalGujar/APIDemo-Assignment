using APIDemo.Models;
using System.Runtime.CompilerServices;

namespace APIDemo.Services
{
    public interface ITaskService
    {
        public Task AddTask(MyTask t);
        public Task DeleteTask(int id);

        public Task<IEnumerable<MyTask>> GetTask();
        public Task UpdateTask(MyTask t);
    }
}
