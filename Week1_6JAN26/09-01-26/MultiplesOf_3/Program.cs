namespace MultiplesOf_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size: ");
            int input2 = int.Parse(Console.ReadLine());
            int output = 0;
            if(input2 < 0)
            {
                output = -2;
            }
            else
            {
                int[] input1 = new int[input2];
                Console.WriteLine("Enter array element: ");

                for(int i = 0; i < input2; i++)
                {
                    input1[i] = int.Parse(Console.ReadLine());
                    if(input1[i] < 0)
                    {
                        output = -1;
                        break;
                    }
                    if (input1[i] % 3 == 0)
                    {
                        output++;
                    }
                }
            }
            Console.WriteLine("Output = " + output);
        }
    }
}
