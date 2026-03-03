using System.Text.RegularExpressions;

namespace date_extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer email: ");
            string text = Console.ReadLine();

            string pattern = @"\b\d(0[1-9]|12[0-9]|3[01])/\d(0[1-9]|1[0-2])/\d{4}\b";
            MatchCollection match = Regex.Matches(text, pattern);

            foreach(Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
