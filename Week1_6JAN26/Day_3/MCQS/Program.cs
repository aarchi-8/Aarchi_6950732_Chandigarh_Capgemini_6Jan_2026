using System;
using System.Collections.Generic;
using System.Text;

namespace MCQS
{
    internal class MCQS
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the Capital of India");
            Console.WriteLine("A: Punjab");
            Console.WriteLine("B: Maharashtra");
            Console.WriteLine("C: Delhi");
            Console.WriteLine("D: Bihar");
            Console.WriteLine("Choose the correct answer: ");
            char ans = char.Parse(Console.ReadLine());
            if (ans == 'C' || ans == 'c')
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }
        }
    }
}
