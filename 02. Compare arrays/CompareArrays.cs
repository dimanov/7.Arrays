/*
 * Problem 2. Compare arrays
 * Write a program that reads two  integer  arrays from the console and compares them element by element.
 */

using System;

class CompareArrays
{
    public static void Main()
    {
        Console.Write("Please enter the lenght of the arrays. \nn= ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] firstArray = ReadArrays("first", arrayLenght);
        int[] secondArray = ReadArrays("second", arrayLenght);
  
        bool equal = false;

        for (int i = 0; i < arrayLenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
            else 
            {
                equal = true;
            }
        }

        Console.WriteLine("The two arrays are {0} equal", equal ? "" : "not");
    }

    public static int[] ReadArrays(string position, int arrLenght)
    {
        Console.WriteLine("Please enter {0} members of the {1} array, separated by a space!", arrLenght, position);
        string array = Console.ReadLine();
        int[] arrParam = new int [arrLenght];
        for (int i = 0; i < arrLenght; i++)
        {
            arrParam[i] = int.Parse(array.Split(' ')[i]);
        }
        return arrParam;
    }
}

