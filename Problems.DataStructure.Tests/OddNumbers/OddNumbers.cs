using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.OddNumbers
{
    public static class OddNumbersClass
    {
        public static int OddOccurrencesInArrayAnswer()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            int result = 0;
            foreach (int element in A)
            {
                result ^= element;
            }

            return result;
        }
        public static int OddOccurrencesInArrayAnswer2()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            int odd = 0;
            for (int i = 0; i < A.Length; i++)
            {
                bool isOdd = true;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        isOdd = false;
                        break;
                    }
                    else
                        isOdd = true;
                }
                if (isOdd)
                    odd = A[i];
            }

            return odd;
        }
    }
}
