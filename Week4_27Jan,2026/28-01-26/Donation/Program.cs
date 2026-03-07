namespace Donation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string size: ");
            int n = int.Parse(Console.ReadLine());
           
            string[] str = new string[n];
            Console.WriteLine("Enter string: ");
            for(int i = 0;  i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter Location: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + UserProgramCode.getDonation(str, input2));
        }
    }
}
