namespace student_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student { StudentID = 1, Name = "Aarchi", Age = 22, DepartmentID = 1 },
                new Student { StudentID = 2, Name = "Rahul", Age = 20, DepartmentID = 2 },
                new Student { StudentID = 3, Name = "Neha", Age = 23, DepartmentID = 1 },
                new Student { StudentID = 4, Name = "Aman", Age = 19, DepartmentID = 3 },
                new Student { StudentID = 5, Name = "Priya", Age = 24, DepartmentID = 2 }
            };


            List<Department> departments = new List<Department> {
                new Department { DepartmentID = 1, DepartmentName = "Computer Science" },
                new Department { DepartmentID = 2, DepartmentName = "Electronics" },
                new Department { DepartmentID = 3, DepartmentName = "Mechanical" }
            };


            List<Course> courses = new List<Course> {
                new Course { CourseID = 1, CourseName = "Data Structures", DepartmentID = 1 },
                new Course { CourseID = 2, CourseName = "Operating Systems", DepartmentID = 1 },
                new Course { CourseID = 3, CourseName = "Digital Electronics", DepartmentID = 2 },
                new Course { CourseID = 4, CourseName = "Thermodynamics", DepartmentID = 3 }
            };


            List<Enrollment> enrollments = new List<Enrollment> {
                new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, Grade = "A" },
                new Enrollment { EnrollmentID = 2, StudentID = 1, CourseID = 2, Grade = "B" },
                new Enrollment { EnrollmentID = 3, StudentID = 2, CourseID = 3, Grade = "A" },
                new Enrollment { EnrollmentID = 4, StudentID = 3, CourseID = 1, Grade = "A" },
                new Enrollment { EnrollmentID = 5, StudentID = 4, CourseID = 4, Grade = "C" }
            };

            var studentOlder = students.Where(s => s.Age > 21).ToList();

            foreach(var o in studentOlder)
            {
                Console.WriteLine("Students Older than 21: "+o.Name);
            }


            var csdept = departments.
                Where(d => d.DepartmentName == "Computer Science")
                .Select(d => d.DepartmentID).FirstOrDefault();

            var csCourse = courses
                .Where(c => c.DepartmentID == csdept)
                .ToList();

            Console.WriteLine("Courses in computer science: ");
            foreach(var c in csCourse)
            {
               
                Console.WriteLine($"{c.CourseID} : {c.CourseName}");
            }


            var result = enrollments
                .Join(courses,
                      e => e.CourseID,
                      c => c.CourseID,
                      (e, c) => new { e, c })
                .Where(x => x.c.CourseName == "Thermodynamics")
                .Join(students,
                      x => x.e.StudentID,
                      s => s.StudentID,
                      (x, s) => s.Name)
                .ToList();

            Console.WriteLine("Names of students enrolled in thermodynamics: ");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

            var re = enrollments
                .Join(courses,
                      e => e.CourseID,
                      c => c.CourseID,
                      (e, c) => new { e, c })
                .Where(x => x.c.CourseName )
                .Join(students,
                      x => x.e.StudentID,
                      s => s.StudentID,
                      (x, s) => s.Name)
                .ToList();
        }
    }
}
