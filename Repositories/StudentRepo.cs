using Microsoft.EntityFrameworkCore;
using StudentManagement.DBContext;
using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext dbContext;
        public StudentRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Student>> getAllStudents()
        {
            var result = await dbContext.students.ToListAsync();
            return result;
        }
    }
}
