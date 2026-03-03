using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter first list: ");
        int[] list1 = Console.ReadLine()
                             .Split(',')
                             .Select(x => int.Parse(x.Trim()))
                             .ToArray();

        Console.Write("Enter second list: ");
        int[] list2 = Console.ReadLine()
                             .Split(',')
                             .Select(x => int.Parse(x.Trim()))
                             .ToArray();

        foreach (int n in list1)
        {
            int sum = list2.Where(x => x == n).Sum();
            Console.WriteLine($"{n}-{sum}");
        }
    }
}
