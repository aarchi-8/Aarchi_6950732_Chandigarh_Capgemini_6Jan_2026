using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorldProject
{
    internal abstract class Animal
    {
        public string Name;
        public string Type;
 
        public static int AnimalCount;

        //static Constructor
        static Animal()
        {
            AnimalCount = 0;
            Console.WriteLine("Welcome to Animal World!");
            Console.WriteLine("Static constructor called once.");
        }

        //Default Constructor
        public Animal()
        {
            Name = "Puffy";
            Type = "Dog";
            AnimalCount++;
            Console.WriteLine("An animal is created.");
        }

        //Parameterized Constructor
        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
            AnimalCount++;
            Console.WriteLine(name + " the " + type + " is Born");
        }
        public abstract void habitat();

        public void Display()
        {
            Console.WriteLine("Animal Name: " + Name + ",Type: " + Type);
        }
    }
    interface AnimalAbility
    {
        void sound();
        void move();
        void jump();
    }
    class Lion: Animal, AnimalAbility
    {
        public Lion(string name) : base(name, " lion")
        {
            Console.WriteLine(name + " Enters the jungle");
        }
        public override void habitat()
        {
            Console.WriteLine("Habitat: Jungle");
        }
        public void sound()
        {
            Console.WriteLine("Sound: Roarrr!");
        }
        public void move()
        {
            Console.WriteLine("Movement: Runs very fast");
        }
        public void jump()
        {
            Console.WriteLine("Lion also jumps");
        }
    }
    class Birds : Animal, AnimalAbility
    {
        public Birds(string name)
        {
            Console.WriteLine(name + " Spreads its wings!");
            name = Console.ReadLine();
        }
        public override void habitat()
        {
            Console.WriteLine("Lives in trees and flies in the sky");
        }
        public void sound()
        {
            Console.WriteLine("sound: ");
            string sound = Console.ReadLine();
        }
        public void move()
        {
            Console.WriteLine("Movement: ");
            string move = Console.ReadLine();   
        }
        public void jump()
        {
            Console.WriteLine("No jump");
        }
    }
}
