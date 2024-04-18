using CrudDemoBlazorServer.Entity;
using DemoBlazorServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace CrudDemoBlazorServer.Data.Configuration
{
    public static class InsertData
    {
        public static void AddStudentData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                StudentName = "Rahul Joshi",
                StudentAge = 18,
                Mobile = 578989009,
                Subject ="Hindi",
                Fees = "2000"
            });

        }

        public static void AddTeacher(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id = 1,
                Name = "Ramesh Joshi"

            });

        }
    }
}
