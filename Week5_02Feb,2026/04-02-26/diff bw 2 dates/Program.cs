using System.Text.RegularExpressions;

namespace diff_bw_2_dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date: ");
            string date1 = Console.ReadLine();
            Console.WriteLine("Enter second date: ");
            string date2 = Console.ReadLine();


            DateTime d1 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);
            int days = (d2 - d1).Days;
            Console.WriteLine(days);
        }
    }
}
