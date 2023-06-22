using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            string[] testCase = new string[p];
            string[] s = { "TTT", "TTH", "THT", "THH", "HTT", "HTH", "HHT", "HHH" };
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < p; i++)
            {
                testCase[i] = Console.ReadLine();
            }
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < s.Length; j++)
                    dict.Add(s[j], 0);
                for (int j = 0; j < testCase[i].Count() - 2; j++)
                {
                    dict[testCase[i].Substring(j, 3)]++;
                }
                foreach (var e in dict)
                    Console.Write(e.Value + " ");
                Console.WriteLine();
                dict.Clear();
            }
        }
    }
}
