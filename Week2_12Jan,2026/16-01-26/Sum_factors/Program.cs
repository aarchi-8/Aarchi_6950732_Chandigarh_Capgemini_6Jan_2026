namespace Sum_factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input1: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Input2: ");
            int input2 = int.Parse(Console.ReadLine());

            if(input1 < 0)
            {
                Console.WriteLine("output: -1");
                return;
            }
            if(input2 > 32627)
            {
                Console.WriteLine("output: -2");
                return;
            }
            int output = 0;
            for(int i = 0; i <= input2; i++)
            {
                if(i % input1 == 0)
                {
                    output += i;
                }
            }
            Console.WriteLine("output: "+ output);

        }
    }
}
