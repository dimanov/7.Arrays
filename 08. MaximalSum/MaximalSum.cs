/*
 * Problem 8. Maximal sum
 * Write a program that finds the sequence of maximal sum in given array.
 */

using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter an integer N! \nn= ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = ReadArray(n);
        //int[] myArray = { 1, -3, 99, 5, -3, -7, -100 };

        if(myArray.Min() >= 0)
        {
            Console.WriteLine(string.Join(", ", myArray));
            Console.WriteLine("The maximal sum is {0} ", myArray.Sum());
        }
        else if (myArray.Max() <= 0)
        {
            Console.WriteLine("The maximal sum is {0} ", myArray.Max());
        }
        else
        {
            Console.WriteLine("The maximal sum is {0} ", MaxSubArraySum(myArray, myArray.Length));
        }
    }

private static int MaxSubArraySum(int[] midArray,int lenght)
{
            /*Kadane's algorithm
            http://www.ritambhara.in/kadanes-algorithm-to-find-maximum-subarray-sum/
            */
 	        int maxSum = 0;
            int midSum = 0;

        for (int i = 0; i < lenght; i++)
        {
            midSum += midArray[i];
             if(midSum < 0)
             {
                 midSum = 0;
             }
            if(maxSum < midSum)
            {
                maxSum = midSum;
            }
        }
        return maxSum;
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