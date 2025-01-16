using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.DataStructure.Tests.Leetcode.Arrays { 
    public static class MaximumSubarray
    {
        public static int MaximumSubarrayAnswer(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int currentSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {                
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
