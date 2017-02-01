using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Console.WriteLine(string.Join(" ", RemoveNegativeNums(nums)));
    }

    static List<int> RemoveNegativeNums(List<int> nums)
    {
        nums.RemoveAll(x => x < 0);
        if (nums.Count == 0)
        {
            Console.WriteLine("empty");
        }
        nums.Reverse();
        return nums;
        //    for (int i = 0; i < nums.Count; i++)
        //    {
        //        if (nums[i] < 0)
        //        {
        //            nums.RemoveAt(i);
        //            i--;
        //        }
        //    }

        //    if (nums.Count != 0)
        //    {
        //        nums.Reverse();
        //        Console.WriteLine(string.Join(" ", nums));
        //    }
        //    else
        //    {
        //        Console.WriteLine("empty");
        //    }
    }
}

