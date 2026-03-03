namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            int result = LS.search(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);
        }
    }
}
