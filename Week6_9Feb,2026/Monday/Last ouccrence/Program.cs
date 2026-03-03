using System;

class Program
{
    static void Main()
    {
        string str = "I am a programmer. I learn at Codeforwin.";
        string word = "I";

        int pos = str.LastIndexOf(word);
        if (pos != -1)
            str = str.Remove(pos, word.Length);

        Console.WriteLine(str);
    }
}
