namespace Gross_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary: ");
            int basicPay = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of working days: ");
            int workingDays = int.Parse(Console.ReadLine());

            if(basicPay < 0)
            {
                Console.WriteLine("Output: -1");
                return;
            }
            if(basicPay > 10000)
            {
                Console.WriteLine("Output: -2");
                return;
            }
            if (workingDays > 31)
            {
                Console.WriteLine("Output: -3");
                return;
            }
            double da = 0.75 * basicPay;
            double hra = 0.50 * basicPay;

            double grossSalary = basicPay + da + hra;

            Console.WriteLine("Output: " + grossSalary);
        }
    }
}
