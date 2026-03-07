using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> products = new Dictionary<string, int>();

        Console.WriteLine("Enter product records (empty line to stop):");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            string[] parts = input.Split('-');
            string id = parts[0];
            int amount = int.Parse(parts[1]);

            if (!products.ContainsKey(id) || products[id] < amount)
                products[id] = amount;
        }

        var sorted = products.OrderByDescending(x => x.Value);

        foreach (var item in sorted)
            Console.WriteLine($"{item.Key}-{item.Value}");
    }
}
