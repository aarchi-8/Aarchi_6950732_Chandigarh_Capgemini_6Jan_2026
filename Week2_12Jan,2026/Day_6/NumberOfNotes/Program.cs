namespace NumberOfNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 500, 100, 50, 10, 1 };
            int output = 0;
            Console.WriteLine("Enter the amount: ");
            int amt = int.Parse(Console.ReadLine());
            
            foreach(int i in arr)
            {
                int count = amt / i;
                amt = amt % i;
                Console.WriteLine( i + "-" + count );
                output += count;
            }
            Console.WriteLine("Number of Notes: " + output);
        }
    }
}
