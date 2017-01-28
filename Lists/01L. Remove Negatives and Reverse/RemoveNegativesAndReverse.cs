using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        RemoveNegativeNums(nums);
        
    }

    static void RemoveNegativeNums(List<int> nums)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] < 0)
            {
                nums.RemoveAt(i);
                i--;
            }
        }

        if (nums.Count != 0)
        {
            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

