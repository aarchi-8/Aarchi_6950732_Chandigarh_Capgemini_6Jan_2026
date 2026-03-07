using System.Runtime.Intrinsics.X86;

namespace RemoveNegatives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array Elements: ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] output = new int[size];
            if (size < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > 0)
                    {
                        output[cnt++] = arr[i];
                    }
                }
            }
            Array.Resize(ref arr, cnt);
            for(int i = 0;i < cnt; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
