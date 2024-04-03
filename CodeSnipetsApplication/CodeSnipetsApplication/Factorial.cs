using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipetsApplication
{
    internal class Factorials
    {
        public static int CalculateFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * CalculateFactorial(number - 1);
        }
    }
}
