using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityManagementSystem.Models;

namespace UniversityManagement.Models
{
        [Table("tblEnrollment")]
    public class Enrollments
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string Grade { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
