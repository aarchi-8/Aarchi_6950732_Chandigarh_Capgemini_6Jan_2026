namespace Fahrenheit_to_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            int fahrenheit = int.Parse(Console.ReadLine());

            double output;

            if (fahrenheit < 0)
            {
                output = -1;
            }
            else
            {
                output = (fahrenheit - 32) * 5.0 / 9.0;
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
