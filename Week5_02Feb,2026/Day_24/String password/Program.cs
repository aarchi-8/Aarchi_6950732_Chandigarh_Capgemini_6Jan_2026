using System.Text.RegularExpressions;

namespace String_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            bool isvalid = Regex.IsMatch(password, pattern);
            if (isvalid)
            {
                Console.WriteLine("strong");
            }
            else
            {
                Console.WriteLine("Weak");
            }
        }
    }
}
