using System.Text.RegularExpressions;

namespace Phone_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = Console.ReadLine();
            string pattern = @"\b\d{10}\b";

            MatchCollection matches = Regex.Matches(phone, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
