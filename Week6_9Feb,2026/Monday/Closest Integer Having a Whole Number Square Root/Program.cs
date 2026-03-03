using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        int lower = (int)Math.Floor(Math.Sqrt(number));
        int upper = (int)Math.Ceiling(Math.Sqrt(number));

        int lowerSquare = lower * lower;
        int upperSquare = upper * upper;

        if (number - lowerSquare <= upperSquare - number)
            Console.WriteLine("Closest perfect square: " + lowerSquare);
        else
            Console.WriteLine("Closest perfect square: " + upperSquare);
    }
}
