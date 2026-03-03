namespace PerformOPerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input1: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter input2: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter case number: ");
            int input3 = int.Parse(Console.ReadLine());
            if ( input1 < 0 && input2 < 0)
            {
                Console.WriteLine("Output: -1");
            }
            
            switch (input3)
            {
                case 1:
                    input3 = input1 + input2;
                    Console.WriteLine("output: "+ input3);
                    break;
                case 2:
                    input3 = input1 - input2;
                    Console.WriteLine("output: " + input3);
                    break;
                case 3:
                    input3 = input1 * input2;
                    Console.WriteLine("output: " + input3);
                    break;
                case 4:
                    input3 = input1 / input2;
                    Console.WriteLine("output: " + input3);
                    break;
                default:
                    Console.WriteLine("output: -2");
                    break;
            }
        }
    }
}
