namespace Search_Remove_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] output = new int[size - 1];
            if(size < 0)
            {
                output = [-1];
                Console.WriteLine("output: "+ output);
            }
            Console.WriteLine("Enter elements in the array: ");
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    output = [-2];
                    Console.WriteLine("output: " + output);
                }
            }
            Console.WriteLine("Search Element: ");
            int search = int.Parse(Console.ReadLine());
            int temp = 0;

            bool found = false;
            for(int i = 0;i < size;i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("output: -1");
                return;
            }
            int index = 0;
            for(int i = 0;i < size ; i++)
            {
                if (arr[i] != search)
                {
                    output[index++] = arr[i];
                }
            }
            Array.Sort(output);
            Console.WriteLine("output: "+ string.Join(", ", output));
        }
    }
}
