/*
 * Problem 15. Prime numbers
 * Write a program that finds all prime numbers in the range [ 1...10 000 000 ]. Use the Sieve of Eratosthenes algorithm.
 * 
 * To find all the prime numbers less than or equal to a given integer n by Eratosthenes' method:
1.Create a list of consecutive integers from 2 through n: (2, 3, 4, ..., n).
2.Initially, let p equal 2, the first prime number.
3.Starting from p, enumerate its multiples by counting to n in increments of p, and mark them in the list (these will be 2p, 3p, 4p, ... ; the p itself should not be marked).
4.Find the first number greater than p in the list that is not marked. If there was no such number, stop. Otherwise, let p now equal this new number (which is the next prime), and repeat from step 3.
 */

using System;
using System.IO;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        int upLimit = 10000000;

        bool[] notPrime = new bool[upLimit + 1];
            SiftPrimes(notPrime, upLimit);

            var primes = notPrime.Select((val, ind) => new { Index = ind, Value = val })
               .Where(num => num.Value == false)
               .Select(num => num.Index.ToString());

            Console.WriteLine(String.Join(", ", primes.ToArray()));
 
        }

    private static void SiftPrimes(bool[] notPrime, long RANGE)
    {
        notPrime[0] = true;
        notPrime[1] = true;

        for (int number = 2; number <= RANGE; number++)
            if (!notPrime[number])
                for (int notPrimeIndex = number * 2; notPrimeIndex <= RANGE; notPrimeIndex += number)
                    notPrime[notPrimeIndex] = true;


    }
}