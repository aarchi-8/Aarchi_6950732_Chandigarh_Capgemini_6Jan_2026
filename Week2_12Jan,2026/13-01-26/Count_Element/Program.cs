using System.Runtime.Intrinsics.X86;

namespace Count_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            if(size < 0)
            {
                Console.WriteLine("-2");
            }
            Console.WriteLine("Enter the Elements: ");
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    Console.WriteLine("-1");
                }
            }
            Console.WriteLine("Enter the key to find in array: ");
            int key = int.Parse(Console.ReadLine());
            if(key < 0)
            {
                Console.WriteLine("-3");
            }
            for(int i = 0; i< size; i++)
            {
                
                if (arr[i] == key)
                {
                    cnt++;
                }
            }
            Console.WriteLine("Enter the count of key in array: " + cnt);
        }
    }
}
