using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        List<string> inputNums = Console.ReadLine().Trim().Split('|').ToList();
        inputNums.Reverse();

        AppendReversedList(inputNums);
    }

    static void AppendReversedList(List<string> inputNums)
    {
        List<string> result = new List<string>();


        for (int i = 0; i < inputNums.Count; i++)
        {
            result.AddRange(inputNums[i].Split(' '));
        }

        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] == "")
            {
                result.RemoveAt(i);
                i--;
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

