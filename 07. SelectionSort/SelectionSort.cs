/*
 * Problem 7. Selection sort
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 */

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter an integer N! \nn= ");
        int n = int.Parse(Console.ReadLine());

        int[] myArray = ReadArray(n);

        int[] newArray = new int[myArray.Length];
        int minNumber;
        int minKey;

        for (int j = 0; j < myArray.Length - 1; j++)
        {
            minKey = j;
            for (int i = j + 1; i < myArray.Length; i++)
            {
                if (myArray[minKey] > myArray[i])
                {
                    minKey = i;
                }
            }

            minNumber = myArray[minKey];
            myArray[minKey] = myArray[j];
            myArray[j] = minNumber;
        }

        Console.Write("The sorted array is: ");
        PrintArrays(myArray, myArray.Length);
    }

    private static void PrintArrays(int[] array, int lenght)
    {
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("{0} ", array[i]);
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