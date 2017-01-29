using System;
using System.Collections.Generic;

class SplitByWordCasing
{
    static void Main()
    {
        char[] separators = new char[]
        {
            ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '
        };
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Lower-case: " + string.Join(", ", GetLowerCaseWords(words)));
        Console.WriteLine("Mixed-case: " + string.Join(", ", GetMixedCaseWords(words)));
        Console.WriteLine("Upper-case: " + string.Join(", ", GetUpperCaseWords(words)));
    }

    static List<string> GetUpperCaseWords(string[] words)
    {
        int upperLetters = 0;
        List<char> wordsToLetters = new List<char>();
        List<string> upperCaseWords = new List<string>();

        foreach (var word in words)
        {
            wordsToLetters.AddRange(word);

            foreach (var letter in wordsToLetters)
            {
                if (char.IsUpper(letter))
                {
                    upperLetters++;
                }
            }
            if (upperLetters == wordsToLetters.Count)
            {
                upperCaseWords.Add(word);
                wordsToLetters.Clear();
                upperLetters = 0;
            }
            else
            {
                wordsToLetters.Clear();
                upperLetters = 0;
            }
        }

        return upperCaseWords;
    }

    static List<string> GetMixedCaseWords(string[] words)
    {
        int lowerLetters = 0;
        int upperLetters = 0;
        List<char> wordsToLetters = new List<char>();
        List<string> mixedCaseWords = new List<string>();

        foreach (var word in words)
        {
            wordsToLetters.AddRange(word);

            foreach (var letter in wordsToLetters)
            {
                if (char.IsLower(letter))
                {
                    lowerLetters++;
                }
                if (char.IsUpper(letter))
                {
                    upperLetters++;
                }
            }
            if (lowerLetters == wordsToLetters.Count || upperLetters == wordsToLetters.Count)
            {
                wordsToLetters.Clear();
                lowerLetters = 0;
                upperLetters = 0;
            }
            else
            {
                mixedCaseWords.Add(word);
                wordsToLetters.Clear();
                lowerLetters = 0;
                upperLetters = 0;
            }
        }

        return mixedCaseWords;
    }

    static List<string> GetLowerCaseWords(string[] words)
    {
        int lowerLetters = 0;
        List<char> wordsToLetters = new List<char>();
        List<string> lowerCaseWords = new List<string>();

        foreach (var word in words)
        {
            wordsToLetters.AddRange(word);

            foreach (var letter in wordsToLetters)
            {
                if (char.IsLower(letter))
                {
                    lowerLetters++;
                }
            }
            if (lowerLetters == wordsToLetters.Count)
            {
                lowerCaseWords.Add(word);
                wordsToLetters.Clear();
                lowerLetters = 0;
            }
            else
            {
                wordsToLetters.Clear();
                lowerLetters = 0;
            }
        }

        return lowerCaseWords;
    }
}

