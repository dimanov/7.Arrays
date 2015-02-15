/*
 * Problem 11. Binary search
 * Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

using System;
using System.Collections;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        //int[] myArray = new int[7] { 1, 2, 3, 4, 5, 6, 8 };
        //int S = 8;

        Console.Write("Please enter the size of an array N! \nn= ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = ReadArray(n);
        Console.Write("Please enter the desired element \nS= ");
        int S = int.Parse(Console.ReadLine());

        object result;
        result = BinarySearchIterative(myArray, S, 0, myArray.Length -1);

        if (result == "No")
        {
            Console.WriteLine("There are no such element {0} in the sorted array" , S);
        }
        else 
        {
            Console.WriteLine("The index of given element {0} in a sorted array of integers is {1}", S, result);
        }
    }

    private static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
    {
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return "No";
    }
    public static int[] ReadArray(int arrLenght)
    {
        Console.WriteLine("Please enter {0} members of the array, separated by comma!", arrLenght);

        int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        return arrParam;
    }
}