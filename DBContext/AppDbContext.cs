using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {            
        }

        public DbSet<Student> students { get; set; }
    }
}
