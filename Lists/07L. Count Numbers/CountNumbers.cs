using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        numbers.Sort();

        int numsCounters = 1;
        int start = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int r = start + 1; r < numbers.Count; r++)
            {
                if (numbers[start] == numbers[r])
                {
                    numsCounters++;
                    i++;
                }
                else
                {
                    start = r - 1;
                    break;
                }
            }

            Console.WriteLine($"{numbers[start]} -> {numsCounters}");
            start++;
            numsCounters = 1;
        }
    }
}


