using System;
using System.Collections.Generic;
using System.Text;

namespace is_or_is_not
{
    internal class UserProgramCode
    {
        public static string negativeString(string input)
        {
            int n = input.Length;
            if(input.Contains("is not"))
            {
                return input;
            }
            if (input.Contains("is"))
            {
                int idx = input.IndexOf(" is") + 4;
                input = input.Insert(idx, "not ");
            }
            return input;
        }
    }
}
