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
                Console.WriteLine("0. Exit App");
                Console.WriteLine("1. Clear Console");
                Console.WriteLine("2. Generate Fibonacci sequence");
                Console.WriteLine("3. Print Star Patterns");
                Console.WriteLine("4. Prime Numbers");
                Console.WriteLine("5. Calculate Factorial");
                Console.WriteLine("6. String Manipulation");
                Console.WriteLine("7. Pelindrome");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        goto begin;
                    case 2:
                        Console.Write("Enter the number of Fibonacci series elements to generate: ");
                        int fibCount = int.Parse(Console.ReadLine());
                        Fibonacci.GenerateFibonacci(fibCount);
                        break;
                    case 3:
                        StarPatternMenu.Menu();
                        break;
                    case 4:
                        Console.Write("Enter the upper limit for prime numbers: ");
                        int primeLimit = int.Parse(Console.ReadLine());
                        PrimeNumbers.PrintPrimes(primeLimit);
                        break;
                    case 5:
                        Console.Write("Enter a number to calculate its factorial: ");
                        int factorialNumber = int.Parse(Console.ReadLine());
                        int factorialResult = Factorials.CalculateFactorial(factorialNumber);
                        Console.WriteLine($"Factorial of {factorialNumber} is: {factorialResult}");
                        break;
                    case 6:
                        StringManipulationMenu.Menu();
                        break;
                    case 7:
                        Console.Write("Enter the word or phrase you would like to be checked: ");
                        string word = Console.ReadLine();
                        Pelindrome.Result(word);
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
