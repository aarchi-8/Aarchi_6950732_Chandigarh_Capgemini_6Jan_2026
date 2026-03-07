namespace Longest_Substring_without_Repeating_char
{
    internal class Program
    {
        public static int Substring(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            int maxCnt = 0;
            int l = 0;
            for(int right = 0; right < s.Length; right++)
            {
                if (map.ContainsKey(s[right]) && map[s[right]] >= l)
                {
                    l = map[s[right]] + 1;
                }
                else
                {
                    map[s[right]] = right;
                    maxCnt = Math.Max(maxCnt, right - l + 1);
                }
            }
            return maxCnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(Substring(str));
        }
    }
}
