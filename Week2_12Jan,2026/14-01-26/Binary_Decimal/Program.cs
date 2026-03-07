namespace Binary_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Binary number: ");
            int num = int.Parse(Console.ReadLine());
            if(num > 11111)
            {
                Console.WriteLine("output: -2");
            }
            int digit = 0;
            int ans = 0;
            int power = 1;
            while(num > 0)
            {
                digit = num % 10;
                if(digit != 0 && digit != 1)
                {
                    ans = -1;
                    Console.WriteLine(ans);
                    break;
                }
                ans += (power * digit);
                power = power * 2;
                num = num / 10;
            }
            Console.WriteLine("output: " + ans);
        }
    }
}
