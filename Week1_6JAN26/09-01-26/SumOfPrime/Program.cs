namespace SumOfPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = int.Parse(Console.ReadLine());

            int output1 = 0;

            if (input2 < 0)
            {
                output1 = -2;
            }
            else
            {
                int[] input1 = new int[input2];
                int primeSum = 0;
                bool primeFound = false;

                Console.WriteLine("Enter array elements:");

                for (int i = 0; i < input2; i++)
                {
                    input1[i] = int.Parse(Console.ReadLine());

                    if (input1[i] < 0)
                    {
                        output1 = -1;
                        break;
                    }

                    int num = input1[i];
                    if (num > 1)
                    {
                        bool isPrime = true;

                        for (int j = 2; j <= Math.Sqrt(num); j++)
                        {
                            if (num % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            primeSum += num;
                            primeFound = true;
                        }
                    }
                }

                if (output1 == 0 && !primeFound)
                {
                    output1 = -3;
                }
                else if (output1 == 0)
                {
                    output1 = primeSum;
                }
            }
            Console.WriteLine("Output1 = " + output1);
        }
    }
}
