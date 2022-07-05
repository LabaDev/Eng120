using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    /// <summary>
    ///  Create a method for each type of loop
    ///  which returns the highest number
    ///  within a list
    /// </summary>
    public static class LoopTypes
    {
        public static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach(int i in nums)
            {
                if (i > highest)
                {
                    highest = i;
                }
            }
            return highest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            int highest  = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            var length = nums.Count;
            var counter = 0;
            var highest = nums[0];
            while (counter < length)
            {
                if (nums[counter] > highest)
                {
                    highest = nums[counter]; 
                }
                counter++;
            }
            return highest;
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            var highest = nums[0];
            var counter = 0;

            do
            {
                if (nums[counter] > highest)
                {
                    highest = nums[counter];   
                }
                counter++;
            }
            while (counter < nums.Count);
            return highest; 
        }
    }
}