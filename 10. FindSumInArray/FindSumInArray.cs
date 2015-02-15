/*
 * Problem 10. Find sum in array
 * Write a program that finds in given array of integers a sequence of given sum  S  (if present).
 */

using System;
using System.Collections;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        //int[] myArray = new int[7] { 4, 3, 1, 4, 2, 5, 8 };
        //int S = 11;

        Console.Write("Please enter the size of an array N! \nn= ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = ReadArray(n);
        Console.Write("Please enter the desired sum \nS= ");
        int S = int.Parse(Console.ReadLine());


        int bestSum;
        int firstPosition = 0;
        int lastPosition = 0;
        for (int j = 0; j < myArray.Length; j++)
        {
            bestSum = 0;
            for (int i = j; i < myArray.Length; i++)
            {
                bestSum += myArray[i];

                if (bestSum > S)
                {
                    break;
                }
                else if (bestSum == S)
                {
                    firstPosition = j;
                    lastPosition = i;
                    Console.WriteLine("The consequtive elements that have sum  of {0} start from {1} position", S, firstPosition);
                    Console.Write("The elements are: ");

                    for (int index = firstPosition; index <= lastPosition; index++)
                    {
                        Console.Write("{0} ", myArray[index]);
                    }

                    Console.WriteLine();
                    return;
                }
            }
        }
        Console.WriteLine("There are no consequtive elements in the array that have sum  of {0}", S);
    }


    public static int[] ReadArray(int arrLenght)
    {
        Console.WriteLine("Please enter {0} members of the array, separated by comma!", arrLenght);

        int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        return arrParam;
    }
}