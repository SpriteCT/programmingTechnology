
using System;

namespace алгосы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 5; i < n * 2; i++)
            {
                for (int j = n; j < 2 * n * (n + 1); j++)
                {
                    int k = 21;
                    while (k > 5)
                    {
                        k = k - 3;
                        s = s + 1;
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
