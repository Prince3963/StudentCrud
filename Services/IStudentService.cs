using StudentManagement.DTOs;
using StudentManagement.HelperServices;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        Task<ServiceResponse<List<StudentDTO>>> getStrudents();
    }
}
