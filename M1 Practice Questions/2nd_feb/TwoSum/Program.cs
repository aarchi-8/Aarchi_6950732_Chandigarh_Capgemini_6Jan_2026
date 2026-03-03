namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter your key: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Index of Two elements: " + two_sum.twoSum(arr,key));
        }
    }
}
