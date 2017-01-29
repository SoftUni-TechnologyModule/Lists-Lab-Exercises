using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Console.WriteLine(string.Join(" ", GetSquareNumbers(numbers)));
    }

    static List<int> GetSquareNumbers(List<int> numbers)
    {
        List<int> squareNumbers = new List<int>();

        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
            {
                squareNumbers.Add(num);
            }
        }

        squareNumbers.Sort((a, b) => b.CompareTo(a));

        return squareNumbers;
    }
}

