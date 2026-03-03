namespace Array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            int listSum = list.Sum();
            int evenSum = list.Where(x => x % 2 == 0).Sum();
            double avglist = list.Average();
            Console.WriteLine("Sum of an array: "+listSum);
            Console.WriteLine("Sum of even numbers: "+evenSum);
            Console.WriteLine("Average of an array: "+avglist);

            int maxlist = list.Max();
            Console.WriteLine("Maximum element of list: "+maxlist);

            int minlist = list.Min();
            Console.WriteLine("minimum element of list: "+ minlist);

            
        }
    }
}
