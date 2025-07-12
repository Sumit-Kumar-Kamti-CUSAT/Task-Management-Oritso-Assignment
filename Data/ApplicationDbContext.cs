using Microsoft.EntityFrameworkCore;
using Task_Management_Oritso_Assignment.Models;

namespace Task_Management_Oritso_Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
