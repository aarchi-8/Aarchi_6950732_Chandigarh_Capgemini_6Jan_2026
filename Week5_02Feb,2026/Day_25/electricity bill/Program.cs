using System.Text.RegularExpressions;

namespace electricity_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First meter reading: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second meter reading: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter rate per unit: ");
            int input3 = int.Parse(Console.ReadLine());

            string pattern = @"\d+";
            MatchCollection match = Regex.Matches(input1, pattern);
            MatchCollection match2 = Regex.Matches(input2, pattern);
            string res1, res2;
            int n1=0, n2=0;
            foreach(Match m1 in match)
            {
                res1 = m1.Value;
                Console.WriteLine("Meter reading 1: " + res1);
                n1 = int.Parse(res1);
            }
            foreach(Match m2 in match2)
            {
                res2 = m2.Value;
                Console.WriteLine("Meter reading 2: " + res2);
                n2 = int.Parse(res2);
            }
            int diff = n2 - n1;
            int amount = diff * input3;
            Console.WriteLine("Amount: " + amount);
        }
    }
}
