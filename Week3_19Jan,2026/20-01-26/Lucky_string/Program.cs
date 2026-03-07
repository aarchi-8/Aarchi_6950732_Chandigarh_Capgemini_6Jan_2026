namespace Lucky_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LuckyString obj = new LuckyString();
            string[] arr = { "P", "A", "S", "G", "P", "F", "H", "A", "B", "D" };

            string result = obj.Valid(arr.Length, arr);
            Console.WriteLine(result);
        }
    }
}
