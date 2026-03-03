using System.Text.RegularExpressions;

namespace Invoice_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Current Invoice number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the increment value: ");
            int input2 = int.Parse(Console.ReadLine());

            string pattern = @"CAP-(\d+)";
            
            Match match = Regex.Match(input1, pattern);
            int re = int.Parse(match.Groups[1].Value);
            int ad =  re + input2;
            string replc = ad.ToString();
            //string match1 = Regex.Replace(input1,pattern, $"CAP-{replc}");
            Console.WriteLine($"CAP-{replc}");
        }
    }
}
