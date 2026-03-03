namespace intermidiate_Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COUNT NUMBER OF DIGITS
            //List<int> li = new List<int> { 1, 2, 3, 3, 4, 1, 4, 5, 1, 2 };

            //Dictionary<int, int> dict = new Dictionary<int, int>();

            //foreach (int i in li)
            //{
            //    if (dict.ContainsKey(i))
            //    {
            //        dict[i]++;
            //    }
            //    else
            //    {
            //        dict[i] = 1;
            //    }
            //}
            //foreach (var i in dict)
            //{
            //    Console.WriteLine($"{i.Key} occurs {i.Value} times");
            //}


            //NUMBER OF TYRES IN EACH DEALERSHIP
            //Console.WriteLine("Enter Number of Dealerships: ");
            //int n = int.Parse(Console.ReadLine());
            //List<int> ans = new List<int>();

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Number of Cars Dealer {i+1} contains: ");
            //    string[] inpt = Console.ReadLine().Split();
            //    int car = int.Parse(inpt[0]);
            //    int bikes = int.Parse(inpt[1]);
            //    int sum = (car * 4) + (bikes * 2);

            //    ans.Add(sum);
            //}
            //int a = 0;
            //foreach (int x in ans)
            //{
            //    Console.WriteLine($"Total Number of tyres in dealership{a+1} is {x}");
            //    a++;
            //}


            //FACTORS OF A NUMBER

            //Console.WriteLine("Enter the number: ");
            //int nums = int.Parse(Console.ReadLine());
            //List<int> ans = new List<int>();

            //for(int i = 1; i < nums; i++)
            //{
            //    if (nums%i == 0)
            //    {
            //        ans.Add(i);
            //    }
            //}
            //foreach(int i in ans)
            //{
            //    Console.WriteLine(i);
            //}


            //MAXIMUM MARKS IN EACH SEMESTER

            //Console.WriteLine("Enter number of semester: ");
            //int sem = int.Parse(Console.ReadLine());
            //// List<int> sub = new List<int>();
            //int[] sub = new int[sem];
            //for(int i = 0; i < sem; i++)
            //{
            //    Console.WriteLine($"Enter the subjects in {i + 1} semster : ");
            //    sub[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < sem; i++)
            //{
            //    Console.WriteLine($"Enter Marks of {i + 1} semester: ");
            //    string[] marksStr = Console.ReadLine().Split();

            //    int maxi = int.MinValue;
            //    for (int j =  0; j < marksStr.Length; j++)
            //    {
            //        int marks = int.Parse(marksStr[j]);

            //        if(marks < 0 || marks > 100)
            //        {
            //            Console.WriteLine("You have entered invalid mark.");
            //            return;
            //        }
            //        if(marks > maxi)
            //        {
            //            maxi = marks;
            //        }
            //    }
            //    Console.WriteLine($"Maximum mark in {i + 1} semester:{maxi}");
            //}


            //MINIMUM DISCOUNT PRICE

            //Console.WriteLine("Enter the Number of Items: ");
            //int items  = int.Parse(Console.ReadLine());

            //Console.WriteLine("Product details--");
            //string ans = null;
            //int mini = int.MaxValue;
            //for(int i = 0; i < items; i++)
            //{
            //    Console.WriteLine($"Product {i + 1} details: ");
            //    string[] prod = Console.ReadLine().Split(",");

            //    int price = int.Parse(prod[1]);
            //    int discount = int.Parse(prod[2]);

            //    int discountP = (price * discount) / 100;
            //    if(discountP < mini)
            //    {
            //        mini = discountP;
            //        ans = prod[0];
            //    }
            //}
            //Console.WriteLine($"Minimum discount for product {ans} is {mini} ");



            //MOVE HASH 
            //Console.WriteLine("Enter Input: ");

            //string input = Console.ReadLine();
            //string hash = "";
            //string other = "";

            //foreach(char c in input)
            //{
            //    if (c == '#')
            //    {
            //        hash += c;
            //    }
            //    else
            //    {
            //        other += c;
            //    }
            //}
            //Console.WriteLine(hash + other);


            //COUNT VALLEYS 
            // VALLEYS is counted when step is U and Height is 0.

            //Console.WriteLine("Enter size: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Sequence of up and down: ");
            //string path = Console.ReadLine();
            //int level = 0;
            //int valleys = 0;

            //foreach( char c in path)
            //{
            //    if(c == 'U')
            //    {
            //        level++;
            //        if(level == 0)
            //        {
            //            valleys++;
            //        }
            //    }
            //    else
            //    {
            //        level--;
            //    }
            //}
            //Console.WriteLine("Count of Valleys: " + valleys);



            //PYTHAGORAM 

            //Console.WriteLine("Enter Limit: ");

            //int limit = int.Parse(Console.ReadLine());

            //for(int a = 1; a <= limit; a++)
            //{
            //    for(int b = 1; b <= limit; b++)
            //    {
            //        for(int c = 1; c <= limit; c++)
            //        {
            //            if(a*a + b*b == c * c)
            //            {
            //                Console.WriteLine($"{a} {b} {c}");
            //            }
            //        }
            //    }
            //}



            // CHECK STRING ROTAION 

            //static bool IsRotation(string A, string B)
            //{
            //    if (A.Length != B.Length)
            //        return false;

            //    string temp = A + A;
            //    return temp.Contains(B);
            //}


            //string A = "ABCD";
            //string B = "CDAB";
            //Console.WriteLine(IsRotation(A, B));


            // Find the Missing Number in an array 

            //static int MissingNumber(int n,int[] arr)
            //{
            //    int ActualSum = n * (n + 1)/2;
            //    int expSum = 0;

            //    foreach(int a in arr)
            //    {
            //        expSum += a;
            //    }

            //    return ActualSum + expSum;
            //}

            //int[] arr = { 1, 2, 4, 5, 6 };
            //int n = 6;
            //Console.WriteLine("Missing Values is "+MissingNumber(n, arr));


            //CHECK IF A NUMBER IS PRIME

            //static bool checkPrime(int nums)
            //{
            //    for(int i = 1; i < nums; i++)
            //    {
            //        if(i % nums != 0)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
            //int nums = 29;
            //Console.WriteLine(checkPrime(nums));


            //Merge Two array list

            static List<int> MergeTwoArrays(int[] list1, int[] list2)
            {
                List<int> ans = new List<int>();

                int i = 0, j = 0;

                while (i < list1.Length && j < list2.Length)
                {
                    if (list1[i] <= list2[j])
                    {
                        ans.Add(list1[i]);
                        i++;
                    }
                    else
                    {
                        ans.Add(list2[j]);
                        j++;
                    }
                }

                // remaining elements
                while (i < list1.Length)
                    ans.Add(list1[i++]);

                while (j < list2.Length)
                    ans.Add(list2[j++]);

                return ans;
            }

            static void Main()
            {
                int[] A = { 1, 3, 5 };
                int[] B = { 2, 4, 6 };

                List<int> ans2 = MergeTwoArrays(A, B);

                foreach (int l in ans2)
                    Console.WriteLine(l);
            }
        }

    }
}
    


