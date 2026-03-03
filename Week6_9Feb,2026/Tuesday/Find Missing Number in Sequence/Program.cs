using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array elements (comma-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

        int n = arr.Length + 1;
        int expectedSum = n * (n + 1) / 2;

        int actualSum = 0;
        foreach (int num in arr)
            actualSum += num;

        Console.WriteLine("Missing Number: " + (expectedSum - actualSum));
    }
}
