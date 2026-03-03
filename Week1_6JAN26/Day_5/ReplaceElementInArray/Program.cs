namespace ReplaceElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = int.Parse(Console.ReadLine());

            if (input2 < 0)
            {
                Console.WriteLine("-2");
                return;
            }

            int[] input1 = new int[input2];
            int[] output1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
                output1[i] = input1[i];
            }

            if (input2 % 2 == 0)
            {
                output1[0] = -3;
            }
            else
            {
                for (int i = 0; i < input2; i++)
                {
                    if (input1[i] < 0)
                    {
                        output1[0] = -1;
                        PrintArray(output1);
                        return;
                    }
                }

                int mid = input2 / 2;

                for (int i = 0; i < mid; i++)
                {
                    int temp = output1[i];
                    output1[i] = output1[input2 - 1 - i];
                    output1[input2 - 1 - i] = temp;
                }
            }

            PrintArray(output1);
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("Output1 = { ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
