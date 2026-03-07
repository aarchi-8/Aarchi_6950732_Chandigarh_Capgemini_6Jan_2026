using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter d: ");
        int d = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < n - 2; i++)
        {
            Dictionary<int, int> remainderCount = new Dictionary<int, int>();

            for (int j = i + 1; j < n; j++)
            {
                int rem = arr[j] % d;

                int needed = (d - ((arr[i] + arr[j]) % d)) % d;

                if (remainderCount.ContainsKey(needed))
                    count += remainderCount[needed];

                if (!remainderCount.ContainsKey(rem))
                    remainderCount[rem] = 0;

                remainderCount[rem]++;
            }
        }

        Console.WriteLine("Number of valid triplets: " + count);
    }
}
