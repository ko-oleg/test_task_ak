using Microsoft.EntityFrameworkCore;

namespace testtask_akvelon.Models
{ 
    public class ApplicationContext : DbContext
    {
        public DbSet<Task> Products { get; set; }
        public DbSet<Project> Projects { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options, DbSet<Task> products, DbSet<Project> projects)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}