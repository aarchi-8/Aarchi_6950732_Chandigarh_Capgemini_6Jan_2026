namespace Check_strings
{
    internal class Program
    {
        public static List<string> CheckStrings(string[] a, string[] b)
        {
            List<string> res = new List<string>();

            for(int i = 0; i < a.Length; i++)
            {
                HashSet<char> set = new HashSet<char>(b[i].ToLower());

                bool ok = true;

                foreach(char x in a[i].ToLower())
                {
                    if (!set.Contains(x))
                    {
                        ok = false;
                        break;
                    }
                }
                res.Add(ok ? "true" : "false");
            }
            return res;
        }
        static void Main(string[] args)
        {
            string[] a = { "Hello", "By", "Tree" };
            string[] b = { "World", "By", "Box" };

            var ans = CheckStrings(a, b);
            Console.WriteLine(string.Join(", ", ans));
        }
    }
}