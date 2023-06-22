using System;

namespace Day04
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] idx = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr = new int[idx[1]];
            int d = 0, sum = 0;

            for (int i = 1; d < arr.Length; i++)
            {
                d += i;

                for (int j = d - i; j < (d >= arr.Length ? arr.Length : d); j++)
                {
                    arr[j] = i;
                }
            }

            for (int i = idx[0] - 1; i < idx[1]; i++)
                sum += arr[i];
            Console.WriteLine(sum);
        }
    }
}
