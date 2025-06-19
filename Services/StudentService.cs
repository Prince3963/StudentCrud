using StudentManagement.DTOs;
using StudentManagement.HelperServices;
using StudentManagement.Models;
using StudentManagement.Repositories;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public async Task<ServiceResponse<List<StudentDTO>>> getStrudents()
        {
            try
            {

                var response = new ServiceResponse<List<StudentDTO>>();

                var data = await studentRepo.getAllStudents();
                if (data == null)
                {
                    response.data = null;
                    response.message = "Get API Not fetched";
                    response.status = false;

                    return response;
                }


                var result = data.Select(s => new StudentDTO
                {
                    studentID = s.studentID,
                    studentName = s.studentName,
                    studentEmail = s.studentEmail,
                    studentMobile = s.studentMobile,
                    studentAge = s.studentAge,
                    studentAddress = s.studentAddress
                }).ToList();

                response.data = result;
                response.message = "Get API successfully fetched";
                response.status = true;

                return response;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
