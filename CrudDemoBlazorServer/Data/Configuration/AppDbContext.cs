using CrudDemoBlazorServer.Entity;
using DemoBlazorServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace CrudDemoBlazorServer.Data.Configuration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            InsertData.AddStudentData(modelBuilder);
            InsertData.AddTeacher(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }    
        public DbSet<Teacher> Teachers { get; set; }      
        

    }

  
}
