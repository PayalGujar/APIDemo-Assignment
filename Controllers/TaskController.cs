using APIDemo.Models;
using APIDemo.Repository;
using APIDemo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService service;
        
        public TaskController(ITaskService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetTask")]
        public async Task<IActionResult> Get() 
        {
            var list=await service.GetTask();
            return Ok(list);
        }
       
        [HttpPost]
        [Route("AddTask")]
        public void Post([FromBody] MyTask t)
        {
            service.AddTask(t);
        }

        // PUT api/<TaskController>/5
        [HttpPut]
        [Route("UpdateTask")]
        public void Put([FromBody] MyTask t)
        {
            service.UpdateTask(t);
        }
        [HttpGet]
        [Route("DeleteTask/{id}")]
        public void Delete(int id)
        {
             service.DeleteTask(id);
        }

    }
}
