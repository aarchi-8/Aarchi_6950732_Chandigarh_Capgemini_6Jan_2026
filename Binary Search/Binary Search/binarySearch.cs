using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search
{
    internal class binarySearch
    {
        public static int BinaryS(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // Check if x is present at mid
                if (arr[mid] == x)
                    return mid;

                // If x greater, ignore left half
                if (arr[mid] < x)
                    low = mid + 1;

                // If x is smaller, ignore right half
                else
                    high = mid - 1;
            }

            // If we reach here, then element was
            // not present
            return -1;
        }
    }
}
