namespace AnimalWorldProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion("Leo");
            lion.Display();
            lion.habitat();

            Animal bird = new Birds("Sira");
            bird.Display();
            bird.habitat();

            Console.WriteLine("Total Animals Created: " + Animal.AnimalCount);
        }
    }
}
