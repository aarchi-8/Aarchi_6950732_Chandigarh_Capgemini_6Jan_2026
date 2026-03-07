using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_to_decimal
{
    internal class UserProgramCode
    {
        public static int ConvertRomanToDecimal(string s)
        {
            int total = 0;
            Dictionary<char, int> romanmap = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10},
                {'L', 50},
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };
            s = s.ToUpper();

            for(int i = 0;i < s.Length; i++)
            {
                int currentValue = romanmap[s[i]];

                if(i+1 < s.Length && romanmap[s[i+1]] > currentValue)
                {
                    total += romanmap[s[i + 1]] - currentValue;
                    i++;
                }
                else
                {
                    total += currentValue;
                }

            }

            return total;
        }
    }
}
