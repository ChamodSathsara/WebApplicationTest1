using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodosServices _todoServices { get; set; }

        public TodosController() {
            _todoServices = new TodosServices();
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
