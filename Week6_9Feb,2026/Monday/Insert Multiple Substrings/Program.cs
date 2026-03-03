using System;

class Program
{
    static void Main()
    {
        string str = "ABCDEF";
        str = str.Insert(0, "Hello");
        str = str.Insert(5, "World");
        str = str.Insert(str.Length, "!");
        Console.WriteLine(str);
    }
}
