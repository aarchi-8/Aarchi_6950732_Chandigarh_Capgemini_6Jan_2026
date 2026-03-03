namespace Search_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            if(size < 0)
            {
                Console.WriteLine("-2");
            }
            Console.WriteLine("Enter array element: ");
            int[] arr = new int[size];
            for(int  i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    Console.WriteLine("-1");
                }
            }
            Console.WriteLine("Enter the key: ");
            int key = int.Parse(Console.ReadLine());
            bool found = false;
            for(int i = 0;i < size; i++)
            {
                if (arr[i] == key)
                {
                    found = true;
                    break;
                }
            }
            if(found)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-3");
            }
        }
    }
}
