using System.Diagnostics.CodeAnalysis;

namespace Avg_multiple_5upto_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            {
                Console.WriteLine("-1");
            }
            if(num > 500)
            {
                Console.WriteLine("-2");
            }
            int i = 1;
            int sum = 0;
            int cnt = 0;
            while(i <= num)
            {
                if(i % 5 == 0)
                {
                    sum += i;
                    cnt++;
                }
                i++;
            }
            Console.WriteLine("output: " + sum / cnt);
        }
    }
}
