namespace Max_diff_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("ENter array: ");
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Diff: "+UserProgramCode.diffIntArray(arr));
        }
    }
}
