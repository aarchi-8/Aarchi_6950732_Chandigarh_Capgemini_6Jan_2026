using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    [Table("tblInstructor")]
    public class Instructor
    {
        public int InstructorId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public int DepartmentId { get; set; }

    }
}
