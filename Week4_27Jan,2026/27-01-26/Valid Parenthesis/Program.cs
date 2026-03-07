namespace Valid_Parenthesis
{
    internal class Program
    {
        public static bool Parenthesis(string s)
        {
            Stack<char> stack = new Stack<char>();

            for(int i =0 ; i < s.Length; i++)
            {
                if (s[i] == '(' ||  s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (s[i] == ')' && top != '(' ||
                        s[i] == '}' && top != '{' ||
                        s[i] == ']' && top != '[')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str = Console.ReadLine();
            Console.WriteLine(Parenthesis(str));
        }
    }
}
