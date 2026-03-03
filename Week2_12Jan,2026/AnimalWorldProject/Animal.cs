using System;
using System.Collections;
using System.Collections.Generic;
using System;

namespace AnimalWorldProject
{
    enum AnimalType
    {
        Lion,
        Bird
    }

    struct AnimalStats
    {
        public int Age;
        public double Weight;

        public void DisplayStats()
        {
            Console.WriteLine("Age: " + Age + " years, Weight: " + Weight + " kg");
        }
    }

    internal abstract class Animal
    {
        public string Name;
        public AnimalType Type;
        public AnimalStats Stats;

        public static int AnimalCount;

        static Animal()
        {
            AnimalCount = 0;
            Console.WriteLine("Welcome to Animal World!");
            Console.WriteLine("Static constructor called once.");
        }

        public Animal(string name, AnimalType type, int age, double weight)
        {
            Name = name;
            Type = type;
            Stats.Age = age;
            Stats.Weight = weight;
            AnimalCount++;

            Console.WriteLine(name + " the " + type + " is Born");
        }

        public abstract void habitat();

        public void Display()
        {
            Console.WriteLine("Animal Name: " + Name + ", Type: " + Type);
            Stats.DisplayStats();
        }
    }

    interface Movable
    {
        void run();
        void move();
        void jump();
    }

    interface AnimalAction
    {
        void eat();
        void sleep();
        void sound();
    }

    class Lion : Animal, Movable, AnimalAction
    {
        public Lion(string name, int age, double weight)
            : base(name, AnimalType.Lion, age, weight)
        {
            Console.WriteLine(name + " enters the jungle");
        }

        public override void habitat()
        {
            Console.WriteLine("Habitat: Jungle");
        }

        public void sound() => Console.WriteLine("Sound: Roarrr!");
        public void sleep() => Console.WriteLine("Lion sleeps for long hours.");
        public void eat() => Console.WriteLine("Lion eats flesh.");
        public void move() => Console.WriteLine("Lion walks slowly while hunting.");
        public void jump() => Console.WriteLine("Lion jumps high.");
        public void run() => Console.WriteLine("Lion runs very fast.");
    }

    class Birds : Animal, Movable, AnimalAction
    {
        public Birds(string name, int age, double weight)
            : base(name, AnimalType.Bird, age, weight)
        {
            Console.WriteLine(name + " spreads its wings!");
        }

        public override void habitat()
        {
            Console.WriteLine("Lives in trees and flies in the sky");
        }

        public void sound() => Console.WriteLine("Sound: Chirp Chirp");
        public void eat() => Console.WriteLine("Eats seeds and insects");
        public void sleep() => Console.WriteLine("Sleeps at night on trees");
        public void move() => Console.WriteLine("Movement: Flying in the sky");
        public void jump() => Console.WriteLine("Birds do not jump");
        public void run() => Console.WriteLine("Birds fly instead of running");
    }
}
