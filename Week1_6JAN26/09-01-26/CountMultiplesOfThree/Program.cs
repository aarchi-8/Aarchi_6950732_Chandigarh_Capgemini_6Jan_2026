namespace CountMultiplesOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int output = 0;

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    output = -1;
                    Console.WriteLine("Output = " + output);
                    return;
                }

                if (arr[i] % 3 == 0)
                {
                    output++;
                }
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
