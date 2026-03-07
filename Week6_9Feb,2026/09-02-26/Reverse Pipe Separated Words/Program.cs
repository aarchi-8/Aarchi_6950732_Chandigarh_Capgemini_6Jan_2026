using System;

class Program
{
    static void Main()
    {
        string input = "one|two|three";
        var words = input.Split('|');
        Array.Reverse(words);
        Console.WriteLine(string.Join("|", words));
    }
}
