using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeFirstMissingPositive
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i=0; i < nums.Length;)
            {
                var num = nums[i];

                Console.WriteLine($"Read {num} at index {i}");

                var toZeroBasedIndex = num - 1;

                if (num > 0 && num < nums.Length && num != nums[toZeroBasedIndex])
                {
                    int temp = nums[toZeroBasedIndex];
                    nums[toZeroBasedIndex] = num;
                    nums[i] = temp;

                    Console.WriteLine($"swapping {num} with {temp}");
                }
                else
                    i++;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return nums[nums.Length - 1] + 1;
        }
    }
}
