using System;
using System.Collections.Generic;
using System.Text;

namespace Count_elements
{
    internal class UserProgramCode
    {
        public static int GetCount(string[] str, char input2)
        {
            int cnt = 0;
            foreach(string s in str)
            {
                foreach(char c in s)
                {
                    if (!char.IsLetter(c))
                    {
                        return -2;
                    }
                }
                //if (s.StartsWith(input2.ToString(), StringComparison.OrdinalIgnoreCase))
                //{
                //    cnt++;
                //}
            }

            char ch = char.ToLower(input2);

            foreach(string s in str)
            {
                if (char.ToLower(s[0]) == ch)
                {
                    cnt++; 
                }
            }
            if(cnt == 0)
            {
                return -1; 
            }
            return cnt;
        }
    }
}
