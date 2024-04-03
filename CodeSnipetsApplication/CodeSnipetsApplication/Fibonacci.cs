using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class Fibonacci
    {
        public static void GenerateFibonacci(int count)
        {
            #region Fibonacci
            // Initialize variables
            // Number of Fibonacci series elements to generate
            int a = 0, b = 1; // Initial Fibonacci series elements

            // Print initial elements
            Console.Write($"{a}, {b}, ");

            // Generate Fibonacci series
            for (int i = 0; i < count - 2; i++)
            {
                // Calculate next Fibonacci number
                int temp = a + b;
                a = b;
                b = temp;

                // Print next Fibonacci number
                Console.Write(temp + ", ");
            }

            Console.WriteLine();
            #endregion
        }
    }
}
