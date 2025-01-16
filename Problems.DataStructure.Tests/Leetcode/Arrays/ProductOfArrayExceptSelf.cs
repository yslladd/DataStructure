using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.DataStructure.Tests.Leetcode.Arrays
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductOfArrayExceptSelfAnswer(int[] nums)
        {
            int[] result = new int[nums.Length];

            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int suffix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }

        public static int[] ProductOfArrayExceptSelfAnswer_OLD(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int answer = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                    {
                        answer *= nums[j];
                    }
                }
                result[i] = answer;
            }


            return result;
        }
    }
}
