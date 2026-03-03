namespace First_nonRepeating_Char
{
    internal class Program
    {
        public static char FirstNonRepeatingChar(string input)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            //count frequency
            foreach (char c in input)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }
            }

            //return first char with 1 frequency
            foreach(char c in input)
            {
                if (map[c] == 1)
                {
                    return c;
                }
            }
            return '\0';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string input = Console.ReadLine();
            Console.WriteLine("First Non Repeating Character: " + FirstNonRepeatingChar(input));
        }
    }
}
