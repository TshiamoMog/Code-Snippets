using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class PrimeNumbers
    {
        public static void PrintPrimes(int limit)
        {
            #region Prime Numbers

            // Iterate through numbers from 2 to 100 (inclusive)
            for (int i = 2; i <= limit; i++)
            {
                bool isPrime = true; // Assume the current number is prime initially

                // Check divisibility of the current number
                for (int j = 2; j <= i / 2; j++)
                {
                    // If the current number is divisible by any number other than itself and 1
                    if (i != j && i % j == 0)
                    {
                        isPrime = false; // Mark the number as not prime
                        break; // Break out of the inner loop since the number is not prime
                    }
                }

                // If the current number is prime, print it
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            #endregion
        }
    }
}
