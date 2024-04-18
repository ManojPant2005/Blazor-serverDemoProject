using CrudDemoBlazorServer.Data.Configuration;
using CrudDemoBlazorServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace CrudDemoBlazorServer.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        //Add New Record
        public async Task<bool> AddNewStudent(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return true;
        }
        //GetEmployee Records by ID
        public async Task<Student> GetStudentById(int studentID)
        {
            Student student = await _context.Students.FirstOrDefaultAsync(x => x.Id == studentID);
            return student;
        }

        //Update Employee Data
        public async Task<bool> UpdateFarmDetails(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return true;

        }

        //Delete Employee Data
        public async Task<bool> DeleteFarmDetails(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
