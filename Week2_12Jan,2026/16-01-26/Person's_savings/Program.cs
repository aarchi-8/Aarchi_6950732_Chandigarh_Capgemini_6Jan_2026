namespace Person_s_savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Savings = 0;
            Console.WriteLine("Enter Salary of the Person: ");
            int Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Person's monthly expenses: ");
            int expenses = int.Parse(Console.ReadLine());

            if (Salary > 9000)
            {
                Console.WriteLine("Output: -1");
                return;
            }
            if(Salary < 0)
            {
                Console.WriteLine("Output: -2");
            }
            Console.WriteLine("Enter Number of Days person worked in a month: ");
            int Days = int.Parse(Console.ReadLine());
            if(Days < 0)
            {
                Console.WriteLine("Output: -2");
            }
            if(Days == 31)
            {
                Salary += 500;
            }
            Savings = Salary -  (Salary * expenses/100);
            Console.WriteLine("Savings: "+ Savings);
        }
    }
}
