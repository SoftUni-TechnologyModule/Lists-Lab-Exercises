using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    nums.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    AddingManyNums(nums, command);
                }
                else if (command[0] == "contains")
                {
                    CheckForCoincidence(nums, command);
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    nums.Remove(nums[index]);
                }
                else if (command[0] == "shift")
                {
                    DisplacementOfNums(nums, command);
                }
                else if (command[0] == "sumPairs")
                {
                    SummingPairsOfNums(nums);
                }
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", nums) + "]");
                return;
            }
        }
    }

    static List<int> SummingPairsOfNums(List<int> nums)
    {
        int start = 0;
        for (int i = 1; i < nums.Count; i++)
        {
            nums[start] = nums[start] + nums[i];
            nums.RemoveAt(i);
            start++;
        }

        return nums;
    }

    static List<int> DisplacementOfNums(List<int> nums, string[] command)
    {
        int index = int.Parse(command[1]);

        List<int> reversedNums = new List<int>();
        int start = 0;
        for (int i = 0; i < index; i++)
        {
            reversedNums.Add(nums[start]);
            nums.RemoveAt(start);
        }

        nums.AddRange(reversedNums);

        return nums;
    }

    static void CheckForCoincidence(List<int> nums, string[] command)
    {
        int value = int.Parse(command[1]);
        int index = 0;
        bool found = false;
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == value)
            {
                index = i;
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }

    static List<int> AddingManyNums(List<int> nums, string[] command)
    {
        List<int> insertMany = new List<int>();

        for (int i = 2; i < command.Length; i++)
        {
            insertMany.Add(int.Parse(command[i]));
        }

        nums.InsertRange(int.Parse(command[1]), insertMany);

        return nums;
    }
}
