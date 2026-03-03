
namespace EmployeeSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter EmployeeSize: ");
            int EmpS = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter Employees skills: ");
            int[] skills = new int[EmpS];
            for(int i = 0; i < EmpS; i++)
            {
                skills[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Team size: ");
            int TeamS = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter Team size Array: ");
            int[] TeamSize = new int[TeamS];
            for (int i = 0; i < TeamS; i++)
            {
                TeamSize[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(skills);
            int l = 0;
            int r = skills.Length - 1;
            int totalStrength = 0;

            foreach (int size in TeamSize)
            {
                int min = skills[l];
                int max = skills[r];

                totalStrength += min + max;

                l++;
                r--;
            }
            Console.WriteLine("Maximum Total Team Strength: " + totalStrength);
        }
    }
}
