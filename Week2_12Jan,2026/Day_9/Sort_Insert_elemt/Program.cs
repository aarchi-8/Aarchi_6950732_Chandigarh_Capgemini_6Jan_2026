namespace Sort_Insert_elemt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size: ");
            int size = int.Parse(Console.ReadLine());
            int output;

            if(size < 0)
            {
                output = -2;
                Console.WriteLine("Output: " + output);
                return;
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
            Console.WriteLine("Enter Inserting Key: ");
            int key = int.Parse(Console.ReadLine());
            Array.Sort(arr1);

            int index = BinarySearchInsertPosition(arr1, key);

            int[] result = new int[size + 1];

            for (int i = 0, j = 0; i < result.Length; i++)
            {
                if (i == index)
                {
                    result[i] = key;
                }
                else
                {
                    result[i] = arr1[j++];
                }
            }
            Console.WriteLine("Output: ");
            foreach(int val in result)
            {
                Console.WriteLine(val + " ");
            }

        }
        static int BinarySearchInsertPosition(int[] arr, int key)
        {
            int l = 0, r = arr.Length - 1;
            while (l < r)
            {
                int mid = l + r / 2;
                if(arr[mid] == key )
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return l;
        }
    }
}
