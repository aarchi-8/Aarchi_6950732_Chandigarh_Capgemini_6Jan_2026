using System;
using System.Collections.Generic;
using System.Text;

namespace University_Enrollment_System
{
    internal class Person
    {
        public string name;
        public string gender;
        public int phoneNo;
        public int Id;
        public Person()
        {
            Console.WriteLine("Enter Person's Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter University ID: ");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gender: ");
            this.gender = Console.ReadLine();
        }
        public void displayProfile()
        {
            Console.WriteLine("---Person's Profile---");
            Console.WriteLine("Name         : "+name);
            Console.WriteLine("University ID: "+Id);
            Console.WriteLine("Gender       : "+ gender);
        }
    }
    class Student : Person
    {
        public string dept;

        public Student()
        {
            Console.WriteLine("Students department: ");
            this.dept = Console.ReadLine();
        }
        public void DisplayStu()
        {
            Console.WriteLine("Course Optd by Student: " + dept);
        }
    }
    class Professor: Person
    {
        public string course;

        public Professor()
        {
            Console.WriteLine("Course assigned to professor: ");
            this.course = Console.ReadLine();
        }
        public void displayCourse()
        {
            Console.WriteLine("Course assigned to professor: "+ course);
        }
    }
    class Staff : Person
    {
        private string role;

        public void RegisterStaff()
        {
            Console.Write("Enter Staff Role: ");
            role = Console.ReadLine();
        }

        public void ViewStaff()
        {
            displayProfile();
            Console.WriteLine("Role: " + role);
        }
    }
}
