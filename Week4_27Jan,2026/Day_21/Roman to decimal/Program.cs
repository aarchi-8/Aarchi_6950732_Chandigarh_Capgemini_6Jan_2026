namespace Roman_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine();
            Console.WriteLine(UserProgramCode.ConvertRomanToDecimal(str));
        }
    }
}
