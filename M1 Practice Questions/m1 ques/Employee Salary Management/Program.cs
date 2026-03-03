namespace Employee_Salary_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary obj = new Salary();

            Console.WriteLine("Total Salary: " + obj.totalSalary());
            Console.WriteLine("Developer Salary: " + obj.getSalary("HR"));

            obj.updateSalary("Manager", 45000);
            Console.WriteLine("Updated Developer Salary: " + obj.getSalary("Manager"));
        }
    }
}
