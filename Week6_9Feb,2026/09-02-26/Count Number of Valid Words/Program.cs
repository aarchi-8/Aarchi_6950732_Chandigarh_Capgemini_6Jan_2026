using System;

class Program
{
    static bool IsValidWord(string word)
    {
        if (word.Length <= 2)
            return false;

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char c in word)
        {
            if (!char.IsLetterOrDigit(c))
                return false; // special character found

            if (char.IsLetter(c))
            {
                char lower = char.ToLower(c);

                if ("aeiou".Contains(lower))
                    hasVowel = true;
                else
                    hasConsonant = true;
            }
        }

        return hasVowel && hasConsonant;
    }

    static int CountValidWords(string[] words)
    {
        int count = 0;

        foreach (string word in words)
        {
            if (IsValidWord(word))
                count++;
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter words separated by space: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int result = CountValidWords(words);

        Console.WriteLine("Number of valid words: " + result);
    }
}

