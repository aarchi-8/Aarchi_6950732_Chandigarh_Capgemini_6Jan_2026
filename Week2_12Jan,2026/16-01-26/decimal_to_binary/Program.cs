namespace decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input1: ");
            int input1 = int.Parse(Console.ReadLine());

            if(input1 < 0)
            {
                Console.WriteLine("Output: -1");
                return;
            }
            if(input1 == 0)
            {
                Console.WriteLine("Output: 0");
                return;
            }
            int cnt = 0;
            int[] output = new int[32];
            while(input1 > 0)
            {
                output[cnt] = input1 % 2;
                cnt++;
                input1 = input1 / 2;
            }
            Array.Resize(ref output, cnt);
            Console.WriteLine("Decimal to Binary: ");
            for(int i = cnt -1; i >= 0; i--)
            {
                Console.Write(output[i]+ " ");
            }
        }
    }
}
