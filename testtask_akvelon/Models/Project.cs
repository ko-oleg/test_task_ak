namespace testtask_akvelon.Models
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public Task Task { get; set; }
        
        public Project(Task task)
        {
            Task = task;
        }
    }
}