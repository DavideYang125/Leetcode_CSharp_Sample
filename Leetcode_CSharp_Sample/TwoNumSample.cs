using System;
using System.Linq;

namespace Leetcode_CSharp_Sample
{
    /**
     * 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
     * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
         */
    public class TwoNumSample
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var secNum = target - num;
                if (nums.Contains(secNum))
                {
                    var secIndex = Array.IndexOf(nums, secNum);
                    if (secIndex != i)
                        return new int[2] {i, secIndex};
                }
            }

            return new int[2] {0, 0};
        }
    }
}