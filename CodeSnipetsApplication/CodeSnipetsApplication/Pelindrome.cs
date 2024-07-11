using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class Pelindrome
    {
        public static void Result(string word)
        {
            Console.WriteLine(IsPelidrome(word));
        }
        private static string IsPelidrome(string pel)
        {
            pel = pel.Replace(" ", "");

            #region Pelindrome
            for (int i = 0; i < pel.Length / 2; i++)
            {
                if (pel[i] != pel[pel.Length - 1 - i]) return $"\'{pel}\' is not a pelindrome.";
            }
            return $"\'{pel}\' is a pelindrome.";
            #endregion
        }
    }
}
