using System;
using System.Collections.Generic;
using System.Text;

namespace digit_sum_in_string_array
{
    internal class UserProgramCode
    {
        public static int SumofDigits(string[] input1)
        {
            int sum = 0;
            foreach(var c in input1)
            {
                foreach(char d in c)
                {
                    if (!char.IsLetterOrDigit(d))
                    {
                        return -1;
                    }

                    if (char.IsDigit(d))
                    {
                        sum += d - '0';
                    }
                }
            }
            return sum;
        }
    }
}
