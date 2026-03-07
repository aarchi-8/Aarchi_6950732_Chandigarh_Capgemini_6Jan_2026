namespace Palindrome_check
{
    internal class Program
    {
        public static bool Palindrome(string input1 )
        {

            int i = 0;
            int j = input1.Length - 1;
            while ( i < j)
            {
                if(input1[i] != input1[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str = Console.ReadLine();
            Console.WriteLine(Palindrome(str));
        }
    }
}
