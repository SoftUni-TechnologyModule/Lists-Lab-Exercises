﻿using System;
using System.Collections.Generic;

class SumReversedNumbers
{
    static void Main()
    {
        string nums = Console.ReadLine();

        ReversingNumbers(nums);
    }

    static void ReversingNumbers(string nums)
    {
        List<char> separateNums = new List<char>();

        separateNums.AddRange(nums);

        List<char> reversedNums = new List<char>();

        for (int i = separateNums.Count - 1; i >= 0; i--)
        {
            reversedNums.Add(separateNums[i]);
        }

        SortingNumbers(reversedNums);
    }

    static void SortingNumbers(List<char> reversedNums)
    {
        string[] sortedNums = new string[reversedNums.Count];
        int start = 0;
        for (int i = 0; i < reversedNums.Count; i++)
        {
            if (reversedNums[i] == ' ')
            {
                start++;
                sortedNums[start] += reversedNums[i];
                start++;
            }

            sortedNums[start] += reversedNums[i];
        }


        PrintSummedNumbers(sortedNums);
    }

    static void PrintSummedNumbers(string[] sortedNums)
    {
        List<long> parsedNums = new List<long>();

        for (int i = 0; i < sortedNums.Length; i++)
        {
            if (sortedNums[i] == null)
            {
                break;
            }
            if (sortedNums[i] == " ")
            {
                continue;
            }
            else
            {
                parsedNums.Add(long.Parse(sortedNums[i]));
            }
        }

        long sum = 0;
        for (int i = 0; i < parsedNums.Count; i++)
        {
            sum += parsedNums[i];
        }

        Console.WriteLine(sum);
    }
}

