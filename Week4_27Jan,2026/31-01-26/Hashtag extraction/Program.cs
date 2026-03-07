using System.Text.RegularExpressions;

namespace Hashtag_extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string text =  Console.ReadLine();
            string pattern = @"#\w+";

            MatchCollection match = Regex.Matches(text, pattern);
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
