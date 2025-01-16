using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.Fibonacci
{
    public static class FibonacciClass
    {
        public static int FibonacciGPT(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciGPT(n - 1) + FibonacciGPT(n - 2);
        }

        public static List<int> Fibonacci(int num)
        {            
            List<int> sequence = new List<int>();

            for (int i = 0; i < num; i++)
            {
                if (i <= 1)
                {
                    sequence.Add(i);
                }
                else
                {
                    int current = sequence[i - 1] + sequence[i - 2];
                    sequence.Add(current);
                }
            }
            return sequence;

        }
    }
}
