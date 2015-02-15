/*
 * Problem 14. Quick sort
 * Write a program that sorts an array of integers using the Quick sort algorithm.
 */

using System;
using System.Linq;
class QuickSort
{
    static void Main()
    {
            //int[] myArray = new int[15] { 4, 3, 1, 4, 2, 5, 8, 2, -4, 13, -20, 5, 16, 8, 14 };

            int[] myArray = ReadArray();
            SortArray(myArray, 0, myArray.Length - 1);
            Console.WriteLine(String.Join(", ", myArray));
     }

        private static int[] ReadArray()
        {
         	    Console.WriteLine("Please enter members of the array, separated by comma!");
        
                int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        
                return arrParam;
        }

        private static void SortArray(int[] numbers, int left, int right)
        {
            int pivot;

            if (left < right)
            {
                pivot = Partition(numbers, left, right);

                if (pivot > 1)
                {
                    SortArray(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortArray(numbers, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];

            while (true)
            {
                while (numbers[left] < pivot) ++left;
                while (numbers[right] > pivot) --right;

                if (numbers[right] == numbers[left] && numbers[left] == pivot)
                    ++left;

                if (left < right)
                {
                    numbers[left] ^= numbers[right];
                    numbers[right] ^= numbers[left];
                    numbers[left] ^= numbers[right];
                }
                else
                    return right;
            }
        }

}