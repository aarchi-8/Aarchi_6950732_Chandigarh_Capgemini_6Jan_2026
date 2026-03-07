using System;

class Program
{
    static bool IsVowel(char c)
    {
        return "aeiouAEIOU".Contains(c);
    }

    static void Main()
    {
        string s = "beautiful";
        int count = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (IsVowel(s[i]) && IsVowel(s[i + 1]))
            {
                count++;
                i++;
            }
        }

        Console.WriteLine(count);
    }
}
