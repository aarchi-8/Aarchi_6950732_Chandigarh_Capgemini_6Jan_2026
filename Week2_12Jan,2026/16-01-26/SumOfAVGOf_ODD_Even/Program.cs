namespace SumOfAVGOf_ODD_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            if(size < 0)
            {
                Console.WriteLine("Output: -2");
                return;
            }

            Console.WriteLine("Enter Array: ");
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(arr[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                    return;
                }
            }
            int sum1 = 0;
            int cnt1 = 0;
            int cnt2 = 0;
            int sum2 = 0;
            for(int i = 0;i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum1 += arr[i];
                    cnt1++;
                }
                else
                {
                    sum2 += arr[i];
                    cnt2++;
                }
            }
            int avg1 = sum1 / cnt1;
            int avg2 = sum2 / cnt2;
            Console.WriteLine("Average of sum of even: " + avg1);
            Console.WriteLine("Average of sum of odd: "+ avg2);
            Console.WriteLine("Password is: " + avg1 + "" + avg2);
        }
    }
}
