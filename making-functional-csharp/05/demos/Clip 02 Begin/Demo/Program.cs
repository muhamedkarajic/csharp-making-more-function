using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static long NaiveFibonacci(int n) =>
            n < 2
                ? n
                : NaiveFibonacci(n - 1) + NaiveFibonacci(n - 2);

        static IList<long> dynamicCache = new List<long>() { 0, 1 };

        static long DynamicFibonacci(int n)
        {
            while (dynamicCache.Count <= n)
            {
                dynamicCache.Add(-1);
            }

            if (dynamicCache[n] < 0)
            {
                if (n < 2)
                {
                    dynamicCache[n] = n;
                }
                else
                {
                    dynamicCache[n] =
                        DynamicFibonacci(n - 1) +
                        DynamicFibonacci(n - 2);
                }
            }

            return dynamicCache[n];
        }

        static void Demonstrate(Func<int, long> fibonacci)
        {
            int offset = 30;
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{offset + i}\t{fibonacci(offset + i)}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Demonstrate(NaiveFibonacci);
            Demonstrate(DynamicFibonacci);

            Console.ReadLine();
        }
    }
}
