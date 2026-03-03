using System;

class Program
{
    static void Main()
    {
        string input = "banana|apple|mango";
        var words = input.Split('|');
        Array.Sort(words);
        Console.WriteLine(string.Join("|", words));
    }
}
