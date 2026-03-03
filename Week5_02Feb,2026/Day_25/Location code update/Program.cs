using System.Text.RegularExpressions;
namespace Location_code_update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current invoice number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter new location code: ");
            string input2 = Console.ReadLine();

            string pattern = @"CAP-(\w+)-1234";

            Match match = Regex.Match(input1, pattern);

            // string match1 = Regex.Replace(input1, pattern, $"CAP-{input2}-1234");
            Console.WriteLine($"CAP-{input2}-1234");
            //Console.WriteLine(match1);
        }
    }
}
