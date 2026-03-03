
using System.Text.RegularExpressions;

namespace Email_validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            string pattern = @"^\w+@\w+.\w+$";
            bool isvalid = Regex.IsMatch(email, pattern);
            if (isvalid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
