using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentID { get; set; }

        [Column("StudentName", TypeName = "varchar(255)")]
        public string studentName { get; set; }

        [Column("StudentAge", TypeName = "int")]
        public int studentAge { get; set; }

        [Column("StudentEmail", TypeName = "varchar(255)")]
        public string studentEmail { get; set; }

        [Column("StudentMobileNumber", TypeName = "varchar(50)")]
        public string studentMobile { get; set; }

        [Column("StudentAddress", TypeName = "varchar(255)")]
        public string studentAddress { get; set; }
    }
}
