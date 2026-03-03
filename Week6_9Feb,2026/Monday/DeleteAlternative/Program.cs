using System;
using System.Text;

class Program
{
    static string DeleteAlternating(string s)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < s.Length; i += 2)
        {
            result.Append(s[i]);
        }

        return result.ToString();
    }

    static void Main()
    {
        string output = DeleteAlternating("abcdef");
        Console.WriteLine(output);
    }
}
