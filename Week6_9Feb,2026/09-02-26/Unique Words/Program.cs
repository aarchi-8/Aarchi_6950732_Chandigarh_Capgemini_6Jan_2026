using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "listen", "silent", "hello", "world", "abc", "cba" };
        var map = new Dictionary<string, List<string>>();

        foreach (var word in words)
        {
            string key = String.Concat(word.OrderBy(c => c));
            if (!map.ContainsKey(key))
                map[key] = new List<string>();
            map[key].Add(word);
        }

        foreach (var group in map.Values)
            if (group.Count == 1)
                Console.WriteLine(group[0]);
    }
}
