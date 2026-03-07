using System.Text.RegularExpressions;

namespace Add_years_to_date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input: ");
            string input = Console.ReadLine();
            string pattern = @"^(0[1-9]|12[0-9]|3[01])/(0[0-9]|1[0-2])|/\d{4}$";
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if(year < 0)
            {
                Console.WriteLine("-2");
            }
            if (!Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("-1");
            }
            DateTime date = DateTime.ParseExact(input, "dd/MM/yyyy", null);

            DateTime newdate = date.AddYears(year);

            Console.WriteLine("Output: " + newdate);
        }
    }
}
