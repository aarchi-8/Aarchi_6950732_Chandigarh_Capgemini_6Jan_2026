using System;

class Program
{
    static bool IsShuffle(string x, string y, string z)
    {
        if (z.Length != x.Length + y.Length) return false;

        int i = 0, j = 0;

        foreach (char c in z)
        {
            if (i < x.Length && c == x[i]) i++;
            else if (j < y.Length && c == y[j]) j++;
            else return false;
        }
        return true;
    }
}
