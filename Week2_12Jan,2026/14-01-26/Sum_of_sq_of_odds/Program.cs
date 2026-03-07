namespace Sum_of_sq_of_odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num  = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("-1");
            }
            int digit = 0;
            int sum = 0;
            while (num > 0)
            {
                digit = num % 10;
                if(digit % 2 != 0)
                {
                    sum += (digit * digit);
                }
                num = num / 10;
            }
            Console.WriteLine("output: " + sum);
        }
    }
}
