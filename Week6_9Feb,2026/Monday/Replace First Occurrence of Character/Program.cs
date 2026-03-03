using System;

class Program
{
    static void Main()
    {
        string str = "I love programming.";
        int index = str.IndexOf('.');
        if (index != -1)
            str = str.Remove(index, 1).Insert(index, "!");

        Console.WriteLine(str);
    }
}
