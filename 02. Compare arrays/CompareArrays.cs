 ﻿/* 
  * Problem 2. Compare arrays 
  * Write a program that reads two  integer  arrays from the console and compares them element by element. 
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
         bool equal = false; 
         if (arrayLenght1 != arrayLenght2) 
         { 
             PrintIfEqualArrays(equal); 
         } 
         else 
         { 
             int arrayLenght = arrayLenght1; 
             int[] firstArray = ReadArrays("first", arrayLenght); 
             int[] secondArray = ReadArrays("second", arrayLenght); 
 
 
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
             PrintIfEqualArrays(equal); 
         } 
     } 
 
     private static void PrintIfEqualArrays(bool equal) 
     { 
         Console.WriteLine("The two arrays are {0} equal", equal ? "" : "not"); 
     } 
 
     public static int[] ReadArrays(string position, int arrLenght) 
     { 
         Console.WriteLine("Please enter {0} members of the {1} array, separated by a space!", arrLenght, position); 
         string array = Console.ReadLine(); 
         int[] arrParam = new int[arrLenght]; 
         for (int i = 0; i < arrLenght; i++) 
         { 
             arrParam[i] = int.Parse(array.Split(' ')[i]); 
         } 
         return arrParam; 
     } 
 } 
