namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int output;

            if (n < 0)
            {
                output = -1;
            }
            else
            {
                int temp = n;
                int reverse = 0;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    reverse = reverse * 10 + digit;
                    temp /= 10;
                }

                if (reverse == n)
                    output = 1;
                else
                    output = -2;
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
