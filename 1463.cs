using System;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            while (n != 1)
            {
                if (n % 3 > 0)
                {
                    if (n % 3 == 1)
                        n--;
                    else if (n % 2 == 0)
                        n = n / 2;
                    else
                        n--;
                }
                else
                    n = n / 3;
                c++;
            }
            Console.WriteLine(c);
        }
    }
}