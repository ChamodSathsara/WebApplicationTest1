using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class TodosServices
    {
        public List<Todo> getAllTasks()
        {

            var tasks = new List<Todo>();

            var task1 = new Todo
            {
                id = 1,
                description = "Test",
                title = "Test",
                Created = DateTime.Now,
                due = DateTime.Now.AddDays(1),
                status = TodoTypes.New
            };
            tasks.Add(task1);

            var task2 = new Todo
            {
                id = 2,
                description = "Test 2 ",
                title = "Test 2 ",
                Created = DateTime.Now,
                due = DateTime.Now.AddDays(1),
                status = TodoTypes.New
            };
            tasks.Add(task2);

            return tasks;

        }
    }
}
