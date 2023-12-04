using APIDemo.Models;

namespace APIDemo.Repository
{
    public interface ITaskRepo
    {
        public Task AddTask(MyTask t);
        public Task DeleteTask(int id);

        public Task<IEnumerable<MyTask>> GetTask();
        public Task UpdateTask(MyTask t);
    }
}
