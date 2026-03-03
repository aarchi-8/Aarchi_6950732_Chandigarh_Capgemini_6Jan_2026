namespace String_compression
{
    internal class Program
    {
        public static string StringCompression(string str)
        {
            char[] chars = str.ToCharArray();
            int idx = 0;
            int n = chars.Length;

            for(int i = 0; i < n; i++)
            {
                char ch = chars[i];
                int count = 0;
                while(i < n && chars[i] == ch)
                {
                    count++;
                    i++;
                }
                if(count == 1)
                {
                    chars[idx++] = ch;
                }

                if(count > 1){
                    chars[idx++] = ch;
                    string s = count.ToString();
                    foreach(char c in s)
                    {
                        chars[idx++] = c;
                    }
                }
                i--;
            }
            Array.Resize(ref chars, idx);
            return new string(chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Compressed string: "+StringCompression(str));
        }
    }
}
