/*
 * Problem 9. Frequent number
 * Write a program that finds the most frequent number in an array.
 */

using System;
using System.Collections;
using System.Linq;


class FrequentNumber
{
    static void Main()
    {
        //int[] myArray = new int { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 4, 4 };

        Console.Write("Please enter an integer N! \nn= ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = ReadArray(n);
        int[] initArray = (int[])myArray.Clone();
        Array.Sort(myArray);

        //foreach (int i in myArray) Console.Write(i + " "); 
        //foreach (int i in initArray) Console.Write(i + " "); 

        //Console.WriteLine(string.Join(", ", myArray));

        FindMaxSequence(myArray);

    }

private static void FindMaxSequence(int[] array)
{
 	int start =0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

            for (int i = 1; i < array.Length; i++) 
            {
            
                if (array[i - 1] != array[i])
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
            Console.WriteLine("The maxumal sequence contains {0} elements.", bestLen);
            Console.Write("The element is: ");

            Console.Write("{0} ",array[bestStart]);

            Console.WriteLine();
}
    public static int[] ReadArray(int arrLenght)
    {
        Console.WriteLine("Please enter {0} members of the array, separated by comma!", arrLenght);

        int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        return arrParam;
    }
}