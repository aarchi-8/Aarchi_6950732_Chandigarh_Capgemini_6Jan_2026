using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            string line = Console.ReadLine();
            Console.WriteLine(line.IndexOf("the"));
            Console.WriteLine(line.IndexOf("of"));
        }
    }
}
