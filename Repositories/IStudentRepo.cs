using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public interface IStudentRepo
    {
        Task<List<Student>> getAllStudents();
    }
}
