using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime EnrollmentDate { get; set; }

    }
}