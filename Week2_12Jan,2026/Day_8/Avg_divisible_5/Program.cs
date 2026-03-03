namespace Avg_divisible_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array: ");
            int size = int.Parse(Console.ReadLine());
            if(size < 0)
            {
                Console.WriteLine("-1");
            }
            Console.WriteLine("Enter elements for array: ");
            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 0;
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    sum += arr[i];
                    cnt++;
                }
            }
            Console.WriteLine("Average of numbers divisible by 5: " + (sum / cnt));
        }
    }
}
