namespace SumMultiplesOf_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int cnt = 0;
            Console.WriteLine("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements of array: ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if(size < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                for(int i = 0; i < size; i++)
                {
                    if (arr[i] < 0)
                    {
                        Console.WriteLine("-2");
                    }
                    if (arr[i] % 5 == 0)
                    {
                        sum += arr[i];
                        cnt++;
                    }
                }
                Console.WriteLine("Sum of multiples of 5: "+sum);
                Console.WriteLine("Average of multiples of 5: " + (sum / cnt));
            }
        }
    }
}
