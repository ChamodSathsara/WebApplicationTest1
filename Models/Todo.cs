namespace WebApplication1.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public DateTime Created { get; set; }
        public TodoTypes status { get; set; }
        public DateTime due {  get; set; }
    }
}
