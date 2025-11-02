using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult tasks()
        {
            var tasks = new string[] { "Task 1", "Task 2 ", "Tasks 3 ", "Task 4" };
            return Ok(tasks);
        }

    }
}
