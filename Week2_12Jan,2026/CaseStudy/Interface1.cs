using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface Interface1
    {
        void test1();
    }
    interface Interface2
    {
        void test1();
    }
    internal class c3 : Interface1, Interface2
    {
        void Interface1.test1()
        {
            Console.WriteLine("this is overriding function of inter1 and inter2 interfaces");
        }
        void Interface2.test1()
        {
            Console.WriteLine("this is overriding function of inter1 and inter2 interfaces");
        }
    }
}