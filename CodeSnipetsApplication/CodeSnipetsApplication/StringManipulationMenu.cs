using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class StringManipulationMenu
    {
        public static void Menu()
        {
            qala:
            Console.WriteLine();
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            StringManipulator manipulator = new StringManipulator(input);

            begin:
            Console.WriteLine();
            Console.WriteLine("Choose the type of manipulation you want to perform:");
            Console.WriteLine("00. Exit");
            Console.WriteLine("01. Reverse letter order in a word");
            Console.WriteLine("02. Reverse word order in a phrase");
            Console.WriteLine("03. Reverse letters and word order");
            Console.WriteLine("04. Count Words");
            Console.WriteLine("05. Convert to Uppercase");
            Console.WriteLine("06. Convert to Lowercase");
            Console.WriteLine("07. Enter a new string");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manipulator.ReverseLetters();
                    goto begin;
                case 2:
                    manipulator.ReverseWords();
                    goto begin;
                case 3:
                    manipulator.ReverseLettersAndWords();
                    goto begin;
                case 4:
                    manipulator.CountWords();
                    goto begin;
                case 5:
                    manipulator.ConvertToUpper();
                    goto begin;
                case 6:
                    manipulator.ConvertToLower();
                    goto begin;
                case 7:
                    Console.Clear();
                    goto qala;
                case 0:
                    Console.WriteLine("Exiting...");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    goto begin;
            }
        }
    }
}
