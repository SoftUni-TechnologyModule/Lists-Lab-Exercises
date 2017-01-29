using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        string nums = Console.ReadLine();

        List<decimal> numsList = nums.Split(' ').Select(decimal.Parse).ToList();

        SumAndPrintEqualNumbers(numsList);

        Console.WriteLine(string.Join(" ", numsList));
    }

    static void SumAndPrintEqualNumbers(List<decimal> numsList)
    {
        for (int i = 0; i < numsList.Count - 1; i++)
        {
            if (numsList[i] == numsList[i + 1])
            {
                numsList[i] = numsList[i] + numsList[i + 1];
                numsList.RemoveAt(i + 1);

                if (i >= 1)
                {
                    i -= 2;
                }
                else
                {
                    i--;
                }

            }
        }
    }
}

