using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class ApplicationMenu
    {
        public void Menu()
        {
            while (true)
            {
                begin:
                Console.WriteLine("1. Generate Fibonacci sequence");
                Console.WriteLine("2. Print Star Patterns");
                Console.WriteLine("3. Prime Numbers");
                Console.WriteLine("4. Calculate Factorial");
                Console.WriteLine("5. String Manipulation");
                Console.WriteLine("6. Clear");
                Console.WriteLine("7. Exit App");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number of Fibonacci series elements to generate: ");
                        int fibCount = int.Parse(Console.ReadLine());
                        Fibonacci.GenerateFibonacci(fibCount);
                        break;
                    case 2:
                        StarPatternMenu.Menu();
                        break;
                    case 3:
                        Console.Write("Enter the upper limit for prime numbers: ");
                        int primeLimit = int.Parse(Console.ReadLine());
                        PrimeNumbers.PrintPrimes(primeLimit);
                        break;
                    case 4:
                        Console.Write("Enter a number to calculate its factorial: ");
                        int factorialNumber = int.Parse(Console.ReadLine());
                        int factorialResult = Factorials.CalculateFactorial(factorialNumber);
                        Console.WriteLine($"Factorial of {factorialNumber} is: {factorialResult}");
                        break;
                    case 5:
                        StringManipulationMenu.Menu();
                        break;
                    case 6:
                        Console.Clear();
                        goto begin;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
