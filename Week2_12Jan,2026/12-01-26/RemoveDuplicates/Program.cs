namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = int.Parse(Console.ReadLine());

            if (input2 < 0)
            {
                Console.WriteLine("Output = { -2 }");
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());

                if (input1[i] < 0)
                {
                    Console.WriteLine("Output = { -1 }");
                    return;
                }
            }

            int[] output = new int[input2];
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < count; j++)
                {
                    if (input1[i] == output[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    output[count] = input1[i];
                    count++;
                }
            }

            Console.Write("Output = { ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(output[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
