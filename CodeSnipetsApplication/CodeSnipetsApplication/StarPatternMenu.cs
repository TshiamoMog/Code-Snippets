using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class StarPatternMenu
    {
        public static void Menu()
        {
            begin:
            Console.WriteLine();
            Console.WriteLine("Choose a pattern to display:");
            Console.WriteLine("00. Exit");
            Console.WriteLine("01. Square");
            Console.WriteLine("02. Increasing Left Sided Right Angled Triangle");
            Console.WriteLine("03. Decreasing Left Sided Right Angled Triangle");
            Console.WriteLine("04. Increasing Right Sided Right Angled Triangle");
            Console.WriteLine("05. Decreasing Right Sided Right Angled Triangle");
            Console.WriteLine("06. Hill Pattern");
            Console.WriteLine("07. Reverse Hill Pattern");
            Console.WriteLine("08. Diamond Pattern");
            Console.WriteLine("09. Hour Glass");
            Console.WriteLine("10. Bowtie Pattern");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplaySquare(ShapeSize());
                    goto begin;
                case 2:
                    DisplayIncreasingLeftSidedTriangle(ShapeSize());
                    goto begin;
                case 3:
                    DisplayDecreasingLeftSidedTriangle(ShapeSize());
                    goto begin;
                case 4:
                    DisplayIncreasingRightSidedTriangle(ShapeSize());
                    goto begin;
                case 5:
                    DisplayDecreasingRightSidedTriangle(ShapeSize());
                    goto begin;
                case 6:
                    DisplayHillPattern(ShapeSize());
                    goto begin;
                case 7:
                    DisplayReverseHillPattern(ShapeSize());
                    goto begin;
                case 8:
                    DisplayDiamondPattern(ShapeSize());
                    break;
                case 9:
                    DisplayHourGlassPattern(ShapeSize());
                    goto begin;
                case 10:
                    DisplayBowtiePattern(ShapeSize());
                    goto begin;
                case 0:
                    Console.WriteLine("Exiting...");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    goto begin;
            }
        }

        #region Helpers
        private static int ShapeSize()
        {
            Console.Write("Enter the size of the pattern you want: ");
            int n = int.Parse(Console.ReadLine());

            return n;
        }
        #endregion

        #region Square
        private static void DisplaySquare(int n)
        {
            // Square Pattern implementation
            // Square
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < n; j++) // From 0 to n
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Increasing Left Sided Right Angled Triangle
        private static void DisplayIncreasingLeftSidedTriangle(int n)
        {
            // Increasing Left Sided Right Angled Triangle Pattern implementation
            // Increasing Left Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Decreasing Left Sided Right Angled Triangle
        private static void DisplayDecreasingLeftSidedTriangle(int n)
        {
            // Decreasing Left Sided Right Angled Triangle Pattern implementation
            // Decreasing Left Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Increasing Right Sided Right Angled Triangle
        private static void DisplayIncreasingRightSidedTriangle(int n)
        {
            // Increasing Right Sided Right Angled Triangle Pattern implementation
            // Increasing Right Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write($"{i + 1} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Decreasing Right Sided Right Angled Triangle
        private static void DisplayDecreasingRightSidedTriangle(int n)
        {
            // Decreasing Right Sided Right Angled Triangle Pattern implementation
            // Decreasing Right Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i; j++) // From 0 to i
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Hill Pattern
        private static void DisplayHillPattern(int n)
        {
            // Hill Pattern implementation
            // Hill Pattern
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < i; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Reverse Hill Pattern
        private static void DisplayReverseHillPattern(int n)
        {
            // Reverse Hill Pattern implementation
            // Reverse Hill Pattern
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i; j++) // From 0 to i
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Diamond Pattern
        private static void DisplayDiamondPattern(int n)
        {
            // Diamond Pattern implementation
            // Diamond Pattern
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < i; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            for (int i = 1; i < n; i++) // From 0 to n 
            {
                for (int j = 0; j < i; j++) // From 0 to i
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Hour Glass
        private static void DisplayHourGlassPattern(int n)
        {
            // Hour Glass Pattern implementation
            // Hour Glass
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i; j++) // From 0 to i
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < i; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region Bowtie Pattern
        private static void DisplayBowtiePattern(int n)
        {
            // Bowtie Pattern implementation
            // Bowtie Pattern
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i + 1; j++) // From 0 to i
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n - 1; j++) // From i to n
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

    }
}
