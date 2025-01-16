using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.Leetcode.Arrays
{
    public static class ThreeSum
    {
        public static IList<IList<int>> ThreeSumAnswer(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
                return result;

            // Sort the array to use the two-pointer technique
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicate values for the first element
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Skip duplicate values for the second and third elements
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }


        public static IList<IList<int>> ThreeSumAnswer_OLD(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length % 3 != 0)
                return result;

            int x, y, z = 0;

            int currentSum = nums[0];
            int maxSum = nums[0];

            for (int j = 0; j < nums.Length; j++)
            {

                for (int i = 0; i < nums.Length; i += 3)
                {
                    IList<int> items = new List<int>();

                    x = nums[j+i];
                    y = nums[i + 1];
                    z = nums[i + 2];

                    if (x != y && x != z && y != z)
                    {
                        int current = x + y + z;
                        if (current == 0)
                        {
                            items.Add(x);
                            items.Add(y);
                            items.Add(z);

                            result.Add(items);
                        }
                    }

                }

            }

            return result;
        }

    }
}
