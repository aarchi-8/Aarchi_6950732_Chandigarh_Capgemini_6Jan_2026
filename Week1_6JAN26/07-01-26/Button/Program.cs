using System;
using System.Collections.Generic;
using System.Text;

namespace Button
{
    internal class Button
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press key:");
            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 0:
                    Console.WriteLine("key pressed :0");
                    break;
                case 1:
                    Console.WriteLine("Key pressed :1");
                    break;
                case 2:
                    Console.WriteLine("Key pressed :2");
                    break;
                case 3:
                    Console.WriteLine("Key pressed :3");
                    break;
                case 4:
                    Console.WriteLine("Key pressed :4");
                    break;
                case 5:
                    Console.WriteLine("Key pressed :5");
                    break;
                case 6:
                    Console.WriteLine("Key pressed :6");
                    break;
                case 7:
                    Console.WriteLine("Key pressed :7");
                    break;
                case 8:
                    Console.WriteLine("Key pressed :8");
                    break;
                case 9:
                    Console.WriteLine("Key pressed :9");
                    break;
                default:
                    Console.WriteLine("NOT ALLOWED");
                    break;
            }
        }
    }
}
