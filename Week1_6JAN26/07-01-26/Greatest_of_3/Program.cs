namespace Greatest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter x value : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y value : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter z value : ");
            z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine("x is the greatest value of three values");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("y is the greatest value of three values");
            }
            else
            {
                Console.WriteLine("z is the greatest value of three values");
            }
        }
    }
}
