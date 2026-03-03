using System;

namespace AnimalWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Animal World===");

            Animal lion = new Lion("simba", 5, 190.5);
            Console.WriteLine();
            lion.Display();
            lion.habitat();

            Console.WriteLine();

            Animal bird = new Birds("Tweety", 2, 0.5);
            Console.WriteLine();
            bird.Display();
            bird.habitat();

            Console.WriteLine("\n---Actions---");

            AnimalAction lionaction = (AnimalAction)lion;
            Movable lionmove = (Movable)lion;

            lionaction.sound();
            lionaction.eat();
            lionaction.sleep();
            lionmove.run();

            Console.WriteLine();

            AnimalAction birdaction = (AnimalAction)bird;
            Movable birdmove = (Movable)bird;

            birdaction.sound();
            birdaction.eat();
            birdmove.run();

            Console.WriteLine("\nTotal Animals Created: " + Animal.AnimalCount);
            Console.WriteLine("\n=== End of Program ===");





            //Animal lion = new Lion("Simba");
            //lion.Display();
            //lion.habitat();

            //Console.WriteLine();

            //Movable lionMove = (Movable)lion;
            //lionMove.move();
            //lionMove.run();
            //lionMove.jump();

            //Console.WriteLine();

            //AnimalAction lionAction = (AnimalAction)lion;
            //lionAction.eat();
            //lionAction.sleep();
            //lionAction.sound();

            //Console.WriteLine();

            //Animal bird = new Birds("Parrot");
            //bird.Display();
            //bird.habitat();

            //Console.WriteLine();

            //Movable birdMove = (Movable)bird;
            //birdMove.move();
            //birdMove.run();
            //birdMove.jump();

            //Console.WriteLine();

            //AnimalAction birdAction = (AnimalAction)bird;
            //birdAction.eat();
            //birdAction.sleep();
            //birdAction.sound();

            //Console.WriteLine("\nTotal Animals Created: " + Animal.AnimalCount);
        }
    }
}
