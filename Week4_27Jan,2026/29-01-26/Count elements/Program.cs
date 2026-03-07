namespace Count_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string: ");
            string[] str = new string[size];

            for(int i  = 0; i < str.Length; i++) 
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter Input2: ");
            char input2 = char.Parse(Console.ReadLine());
            Console.WriteLine("output: " + UserProgramCode.GetCount(str, input2));
        }
    }
}
