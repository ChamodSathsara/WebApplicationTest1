using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoRepository _todoServices;

        public TodosController(ITodoRepository _repository) {
            _todoServices = _repository;
        }


        [HttpGet("{id?}")]
        public IActionResult getTasks(int? id) {
            var tasks = _todoServices.getAllTasks();

            if (id is null)
            {
                return Ok(tasks);
            }
            else {
                var selectedtask = tasks.Where(t => t.id == id);
                return Ok(selectedtask);
            }

          
        
        }


    }
}
