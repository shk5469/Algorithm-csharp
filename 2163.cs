using System;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] idx = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = idx[0], m = idx[1];
            Console.WriteLine((n - 1) + (n * (m - 1)));
        }
    }
}
