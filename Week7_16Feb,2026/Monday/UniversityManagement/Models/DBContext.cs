using Microsoft.EntityFrameworkCore;
using UniversityManagement.Models;

namespace UniversityManagementSystem.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Enrollments> Enrollments { get; set; }

        public DbSet<Instructor> Instructor { get; set; }
    }
}