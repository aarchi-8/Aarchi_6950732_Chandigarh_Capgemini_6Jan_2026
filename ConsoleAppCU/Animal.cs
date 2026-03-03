using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCU
{
    internal class Animal
    {
        public string name;
        public int legs;
        public int height;
        public string color;

        Animal(string name, int  legs, int height)
        {
            this.name = name;
            this.legs = legs;
            this.height = height;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
        public static void Main(string[] args)
        {
            Animal obj1 = new Animal("dog",4, 60);
            Animal obj2 = new Animal("cat",4, 30);
            obj1.Sleep();
            obj1.Eat();
            obj2.Sleep();
            obj2.Eat();
        }
    }
}
