namespace Second_largestElmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int output;
            if(size < 0)
            {
                output = -2;
            }

            Console.WriteLine("Enter array: ");
            int[] arr1 = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    output = -1;
                    Console.WriteLine("Output: " + output);
                    return;
                }
            }
            Array.Sort(arr1);
            Console.WriteLine("Output: " + arr1[size - 2]);
        }
    }
}
