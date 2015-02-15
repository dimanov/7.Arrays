/*
 * Problem 3. Compare char arrays
 * Write a program that compares two  char  arrays lexicographically (letter by letter).
 */

using System;

class CompareArrays
{
    public static void Main()
    {
        Console.Write("Please enter the lenght of the first array. \nn= ");
        int arrayLenght1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of the second arrays. \nm= ");
        int arrayLenght2 = int.Parse(Console.ReadLine());

        char[] firstArray = ReadArrays("first", arrayLenght1);
        char[] secondArray = ReadArrays("second", arrayLenght2);

        int result = 0;
        {
            int endCheck;
            int endString;
            if (arrayLenght1 <= arrayLenght2)
            {
                endCheck = arrayLenght1;
                endString = arrayLenght2;
            }
            else
            {
                endCheck = arrayLenght2;
                endString = arrayLenght1;
            }

            for (int i = 0; i < endCheck; i++)
            {
                if ((int)(firstArray[i]) == (int)(secondArray[i]))
                {
                    result += 1;
                }
                else if ((int)(firstArray[i]) < (int)(secondArray[i]))
                {
                    result -= 1;
                }
                else
                {
                    result += 2;
                }
            }

            PrintIfEqualArrays(result, endString, arrayLenght1, arrayLenght2);
        }
    }

    public static char[] ReadArrays(string position, int arrLenght)
    {
        Console.WriteLine("Please enter {0} chars of the {1} array, separated by a space!", arrLenght, position);
        string array = Console.ReadLine();
        char[] arrParam = new char[arrLenght];
        for (int i = 0; i < arrLenght; i++)
        {
            arrParam[i] = char.Parse(array.Split(' ')[i]);
        }
        return arrParam;
    }

    private static void PrintIfEqualArrays(int comparison, int biggerLenght, int firstLenght, int secondLenght)
    {
        if ((comparison + biggerLenght) == (firstLenght + secondLenght))
        {
            Console.WriteLine("The two arrays are equal");
        }
        else if (comparison < biggerLenght)
            Console.WriteLine("The first array is LESS than the second one");
        else
        {
            Console.WriteLine("The first array is BIGGER than the second one");
        }
    }
}
