using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    internal class Pattern
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
