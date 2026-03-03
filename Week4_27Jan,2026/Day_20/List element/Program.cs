namespace List_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size:");
            int n = int.Parse(Console.ReadLine());

            List<int> l = new List<int>();
            for(int i = 0; i < n; i++)
            {
                l.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter input2: ");
            int input = int.Parse(Console.ReadLine());

            List<int> res = UserProgramCode.GetElement(l, input);

            Console.Write("result: ");
            foreach(int x in res)
            {
                Console.Write(x + " ");
            }
        }
    }
}
