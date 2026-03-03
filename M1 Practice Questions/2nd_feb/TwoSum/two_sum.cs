using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    internal class two_sum
    {
        public static List<int> twoSum(int[] arr, int key)
        {
            int n = arr.Length;
            int l = 0;
            int r = n - 1;
            List<int> list = new List<int>();

            while(l < r)
            {
                int sum = arr[l]+ arr[r];
                if(sum == key)
                {
                    list.Add(l);
                    list.Add(r);
                    break;
                }
                else if (sum > key)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            return list;
        }
    }
}
