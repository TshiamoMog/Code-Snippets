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
            Console.WriteLine("Choose a pattern to display:");
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

            Console.WriteLine("Enter the size of the pattern you want: ");
            int n = int.Parse(Console.ReadLine());
            StarPatterns menu = new StarPatterns();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the size of the square:");
                    DisplaySquare(n);
                    break;
                case 2:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayIncreasingLeftSidedTriangle(n);
                    break;
                case 3:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayDecreasingLeftSidedTriangle(n);
                    break;
                case 4:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayIncreasingRightSidedTriangle(n);
                    break;
                case 5:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayDecreasingRightSidedTriangle(n);
                    break;
                case 6:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayHillPattern(n);
                    break;
                case 7:
                    Console.WriteLine("Enter the size of the pattern:");
                    DisplayReverseHillPattern(n);
                    break;
                case 8:
                    Console.WriteLine("Enter the size of the diamond:");
                    DisplayDiamondPattern(n);
                    break;
                case 9:
                    Console.WriteLine("Enter the size of the hour glass:");
                    DisplayHourGlassPattern(n);
                    break;
                case 10:
                    Console.WriteLine("Enter the size of the bowtie:");
                    DisplayBowtiePattern(n);
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }


        private static void DisplaySquare(int n)
        {
            // Square Pattern implementation
            #region Square
            // Square
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < n; j++) // From 0 to n
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Console.WriteLine();

            //for (int i = 0, p = i + 1; i < n; i++, p++) // From 0 to n
            //{
            //    for (int j = 0; j < n; j++) // From 0 to n
            //    {
            //        Console.Write(p + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0, p = n; i < n; i++, p--) // From 0 to n
            //{
            //    for (int j = 0; j < n; j++) // From 0 to n
            //    {
            //        Console.Write(p + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++) // From 0 to n
            //{
            //    int p = i + 1;
            //    for (int j = 0; j < n; j++) // From 0 to n
            //    {
            //        Console.Write(p++ + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++) // From 0 to n
            //{
            //    int p = n;
            //    for (int j = 0; j < n; j++) // From 0 to n
            //    {
            //        Console.Write(p-- + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.WriteLine();
        }

        private static void DisplayIncreasingLeftSidedTriangle(int n)
        {
            // Increasing Left Sided Right Angled Triangle Pattern implementation
            #region Increasing Left Sided Right Angled Triangle
            // Increasing Left Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = 0; j < i + 1; j++) // From 0 to i + 1
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine();
        }

        private static void DisplayDecreasingLeftSidedTriangle(int n)
        {
            // Decreasing Left Sided Right Angled Triangle Pattern implementation
            #region Decreasing Left Sided Right Angled Triangle
            // Decreasing Left Sided Right Angled Triangle
            for (int i = 0; i < n; i++) // From 0 to n
            {
                for (int j = i; j < n; j++) // From i to n
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine();
        }

        private static void DisplayIncreasingRightSidedTriangle(int n)
        {
            // Increasing Right Sided Right Angled Triangle Pattern implementation
            #region Increasing Right Sided Right Angled Triangle
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayDecreasingRightSidedTriangle(int n)
        {
            // Decreasing Right Sided Right Angled Triangle Pattern implementation
            #region Decreasing Right Sided Right Angled Triangle
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayHillPattern(int n)
        {
            // Hill Pattern implementation
            #region Hill Pattern
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayReverseHillPattern(int n)
        {
            // Reverse Hill Pattern implementation
            #region Reverse Hill Pattern
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayDiamondPattern(int n)
        {
            // Diamond Pattern implementation
            #region Diamond Pattern
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayHourGlassPattern(int n)
        {
            // Hour Glass Pattern implementation
            #region Hour Glass
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
            #endregion

            Console.WriteLine();
        }

        private static void DisplayBowtiePattern(int n)
        {
            // Bowtie Pattern implementation
            #region Bowtie Pattern
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
            #endregion

            Console.WriteLine();
        }
        public static void PrintSquare(int n)
        {
            #region Star Pattern
            #endregion
        }
        // Other star patterns can be implemented similarly
    }
}
