using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.DTOs;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await studentService.getStrudents();
            if (result.data == null)
            {
                ViewBag.Message = result.message;
                return View(new List<StudentDTO>());
            }
            return View(result.data);
        }
    }
}
