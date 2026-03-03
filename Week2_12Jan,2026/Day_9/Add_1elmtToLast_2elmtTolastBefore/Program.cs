namespace Add_1elmtToLast_2elmtTolastBefore
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
            }

            Console.WriteLine("Enter array1: ");
            int[] arr1 = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                if (arr1[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }

            Console.WriteLine("Enter array2: ");
            int[] arr2 = new int[size];
            for (int i = 0;i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr2[i] < 0)
                {
                    Console.WriteLine("Output: -1");
                }
            }


            int[] output = new int[size];
            for(int i = 0;i < size ; i++)
            {
                output[i] = arr1[i] + arr2[size - 1 - i];
            }
            Console.WriteLine("Output: ");
            for(int i = 0;i < size ;i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
