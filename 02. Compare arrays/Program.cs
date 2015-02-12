/*
 * Problem 2. Compare arrays
 * Write a program that reads two  integer  arrays from the console and compares them element by element.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the lenght of the arrays! \nn= ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayLenght];
        int[] secondArray = new int[arrayLenght];
        Console.WriteLine("Please enter the members of the first array!");
        for (int i = 0; i < arrayLenght; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayLenght; i++)
        {
            int[] numbers1 = Console.ReadLine().Split[int.Parse()].      
                Select(int.Parse).ToArray;
        }

    }
}