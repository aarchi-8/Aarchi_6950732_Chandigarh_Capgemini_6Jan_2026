using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of friends (N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter time in seconds (T): ");
        int T = int.Parse(Console.ReadLine());

        int current = 1;
        int direction = 1; // +1 forward, -1 backward
        int prev = 1;

        for (int sec = 1; sec <= T; sec++)
        {
            prev = current;
            current += direction;

            // reverse at ends
            if (current == N || current == 1)
                direction *= -1;
        }

        Console.WriteLine($"In last second: {prev} passed ball to {current}");
    }
}
