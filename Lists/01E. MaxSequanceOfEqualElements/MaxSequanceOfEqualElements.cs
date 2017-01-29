using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> numsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        GetAndPrintMaxSequance(numsArray);

    }

    static void GetAndPrintMaxSequance(List<int> numsArray)
    {
        int start = 0;
        int bestStart = 0;
        int len = 1;
        int bestLenght = 1;
        for (int pos = 1; pos < numsArray.Count; pos++)
        {
            if (numsArray[start] == numsArray[pos])
            {
                len++;

                if (len > bestLenght)
                {
                    bestLenght = len;
                    bestStart = start;
                }
            }
            else
            {
                start = pos;
                len = 1;
            }
        }

        for (int i = 0; i < bestLenght; i++)
        {
            Console.Write($"{numsArray[bestStart]} ");
        }

        Console.WriteLine();
    }
}

