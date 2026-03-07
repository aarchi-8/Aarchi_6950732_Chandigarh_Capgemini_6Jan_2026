namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's marks: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade > 90 && grade <= 100)
            {
                Console.WriteLine("Excellent marks");
            }
            else if (grade > 75 && grade <= 90)
            {
                Console.WriteLine("Good ");
            }
            else if (grade > 60 && grade <= 75)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Not passed");
            }
        }
    }
}
