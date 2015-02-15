/*
 * Problem 6. Maximal K sum
 * Write a program that reads two integer numbers  N  and  K  and an array of  N  elements from the console.
 * Find in the array those  K  elements that have maximal sum.
 */

using System;

class MaxKSum
{
    static void Main()
    {
        Console.Write("Please enter an integer N! \nn= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter an integer (K<N)! \nk= ");
        int k = int.Parse(Console.ReadLine());

        int[] myArray = ReadArray(n);
        int sumK;
        int bestSum = 0;
        int position = 0;
        for (int i = 0; i < n - k; i++ )
        {
            sumK = 0;
            for (int j = i; j < i + k; j++)
            {
                sumK += myArray[j];
            }
            if (bestSum < sumK)
             {
                 bestSum = sumK;
                 position = i;
             }
        }
        Console.WriteLine("The {0} elements that have maxumal sum  of {1} start from {2} position", k, bestSum, position);
        Console.Write("The elements are: ");

        for (int i = position; i < position + k; i++)
        {
            Console.Write("{0} ", myArray[i]);
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
