using System.Runtime.CompilerServices;

namespace Alphabets_Vowels
{
    internal class Program
    {
        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        static bool IsCommonConsonant(char c, string word)
        {
            c = char.ToLower(c);

            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToLower(word[i]) == c)
                    return true;
            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine("enter first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("enter second word: ");
            string word2 = Console.ReadLine();

            string temp = "";

            for (int i = 0; i < word1.Length; i++)
            {
                char c = word1[i];

                if (!IsVowel(c) && IsCommonConsonant(c, word2))
                    continue;

                temp += c;
            }
            Console.WriteLine("Result after removing common consonants: "+ temp);

            string result = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0 || char.ToLower(temp[i]) != char.ToLower(temp[i - 1]))
                    result += temp[i];
            }

            Console.WriteLine("Result after removing consequtive duplicates: "+result);
        }
    }
}
