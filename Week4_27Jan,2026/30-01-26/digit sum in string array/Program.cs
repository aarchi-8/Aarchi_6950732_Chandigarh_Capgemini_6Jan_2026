namespace digit_sum_in_string_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String size: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter String: ");
            string[] str = new string[n];
            for(int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Sum: "+ UserProgramCode.SumofDigits(str));
        }
    }
}
