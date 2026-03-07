namespace hi_how_are_you
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            string pattern = @"Hi How are you ";
            string add = pattern + name;
            Console.WriteLine(add);
        }
    }
}
