namespace Count_vowels
{
    internal class Program
    {
        public static int Count_vowels(string input)
        {
            int cnt = 0;
            char[] ch = input.ToCharArray();

            int i = 0;
            while (i < input.Length)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    cnt++;
                }
                i++;
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Vowels Count: "+Count_vowels(str));
        }
    }
}
