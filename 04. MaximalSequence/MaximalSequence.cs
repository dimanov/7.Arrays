/*
 * Problem 4. Maximal sequence
 * Write a program that finds the maximal sequence of equal elements in an array.
 */

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Please enter the lenght of the array. \nn= ");
        int arrayLenght = int.Parse(Console.ReadLine());

        int[] myArray = ReadArray(arrayLenght);
        int start =0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 1; i < arrayLenght; i++) 
        {
            
                if (myArray[i - 1] != myArray[i])
                {
                    start = i;
                    len = 1;
                }
                else 
                {
                    len += 1;
                }
                if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = start;
                }
        }
        Console.WriteLine("The maxumal sequence contains {0} elements, starting from {1} position", bestLen, bestStart);
        Console.Write("The elements are: ");

        for (int i = bestStart; i < (bestStart + bestLen); i++)
        {
            Console.Write("{0} ",myArray[i]);
        }

        Console.WriteLine();
    }
    public static int[] ReadArray(int arrLenght)
    {
        Console.WriteLine("Please enter {0} members of the array, separated by comma!", arrLenght);
        string array = Console.ReadLine();
        int[] arrParam = new int[arrLenght];
        for (int i = 0; i < arrLenght; i++)
        {
            arrParam[i] = int.Parse(array.Split(',')[i]);
        }
        return arrParam;
    }


}