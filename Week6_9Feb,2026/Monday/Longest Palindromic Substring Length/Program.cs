using System;

class Program
{
    static int Expand(string s, int l, int r)
    {
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            l--;
            r++;
        }
        return r - l - 1;
    }

    static void Main()
    {
        string s = "babad";
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            max = Math.Max(max, Expand(s, i, i));
            max = Math.Max(max, Expand(s, i, i + 1));
        }

        Console.WriteLine(max);
    }
}
