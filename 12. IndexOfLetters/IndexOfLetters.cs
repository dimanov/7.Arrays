/*
 * Problem 12. Index of letters
 * Write a program that creates an array containing all letters from the alphabet ( A-Z ).
 * Read a word from the console and print the index of each of its letters in the array.
 */

using System;
using System.Text;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine().Trim().ToUpper();

        Console.WriteLine(String.Join(" ", GetIndices(word)));

    }

    private static void PrintArray()
    {
        throw new NotImplementedException();
    }

    private static int[] GetIndices(string word)
    {
        int[] index = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
            index[i] = word[i] - 'A';

        return index;

    }
}