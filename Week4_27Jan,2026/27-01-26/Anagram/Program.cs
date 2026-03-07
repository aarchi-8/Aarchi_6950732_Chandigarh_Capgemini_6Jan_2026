namespace Anagram
{
    internal class Program
    {
        public static bool Anagram(string input1, string input2)
        {
            char[] s = input1.ToCharArray();
            char[] t = input2.ToCharArray();

            if (s.Length != t.Length)
            {
                return false;
            }
            Array.Sort(s);
            Array.Sort(t);
            if (s == t)
            {
                return true;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String1: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string2: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("Anagram check: "+ Anagram(str1 , str2));
        }
    }
}
