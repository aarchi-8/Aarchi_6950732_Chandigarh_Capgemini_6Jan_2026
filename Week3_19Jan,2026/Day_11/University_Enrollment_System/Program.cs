namespace University_Enrollment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.displayProfile();
            s.DisplayStu();

            Console.WriteLine("--------------");

            Professor p = new Professor();
            p.displayProfile();
            p.displayCourse();

            Console.WriteLine("--------------");

            Staff st = new Staff();
            st.RegisterStaff();
            st.ViewStaff();
        }
    }
}
