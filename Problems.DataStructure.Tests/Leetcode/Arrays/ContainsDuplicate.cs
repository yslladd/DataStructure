using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.Leetcode.Arrays { 
   public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateNumbers_OLD(int[] nums)
        {
            bool result = false;
            List<int> list = new List<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                list.RemoveAt(i);
                if (list.Contains(nums[i]))
                {
                    result = true;
                    break;
                }
                list = new List<int>(nums);
            }
            return result;
        }

        public static bool ContainsDuplicateNumbers(int[] nums)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in nums)
            {                
                if (!seenNumbers.Add(num))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
