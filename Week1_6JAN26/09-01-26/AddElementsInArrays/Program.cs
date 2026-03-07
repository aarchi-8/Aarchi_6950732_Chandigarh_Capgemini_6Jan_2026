namespace AddElementsInArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input3 = int.Parse(Console.ReadLine());

            if (input3 < 0)
            {
                int[] output = new int[1];
                output[0] = -2;
                Console.WriteLine("Output = { -2 }");
                return;
            }

            int[] input1 = new int[input3];
            int[] input2 = new int[input3];
            int[] output1 = new int[input3];

            Console.WriteLine("Enter elements of Input1:");
            for (int i = 0; i < input3; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of Input2:");
            for (int i = 0; i < input3; i++)
            {
                input2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0 || input2[i] < 0)
                {
                    output1[0] = -1;
                    PrintArray(output1);
                    return;
                }
            }

            for (int i = 0; i < input3; i++)
            {
                output1[i] = input1[i] + input2[input3 - 1 - i];
            }

            PrintArray(output1);
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("OUTPUT = { ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
        }
    }
}
