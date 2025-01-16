using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.DataStructure.Tests.BinaryGapInteger
{
    public static class BinaryGap
    {
        public static int GetBinaryGap(int N)
        {
            // Convert the integer to binary representation
            string binaryRepresentation = Convert.ToString(N, 2);

            // Initialize variables to track the current gap length and the maximum gap length
            int currentGap = 0;
            int maxGap = 0;

            // Iterate through the binary representation
            foreach (char bit in binaryRepresentation)
            {
                if (bit == '0')
                {
                    // Increment the current gap length if the bit is 0
                    currentGap++;
                }
                else
                {
                    // Update the maximum gap if the bit is 1 and reset the current gap
                    maxGap = Math.Max(maxGap, currentGap);
                    currentGap = 0;
                }
            }

            // Return the maximum gap
            return maxGap;
        }
    }
}
