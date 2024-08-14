using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// This method adds two values passed through and returns the sum of the two
        /// </summary>
        /// <param name="a"> The first digit to be added </param>
        /// <param name="b"> The second digit to be added </param>
        /// <returns> returns the sum of 'a' and 'b' </returns>
        public static double Add(double a, double b)
        {
            double total = a + b;
            return total;
        }

        /// <summary>
        /// This method subtracts the second value passed
        /// through from the first value passed through
        /// and returns the difference
        /// </summary>
        /// <param name="a"> The value we will be subtracting from </param>
        /// <param name="b"> the amount we will subtract  </param>
        /// <returns> returns the difference </returns>
        public static double Subtract(double a, double b)
        {
            double total = a - b;
            return total;
        }

        /// <summary>
        /// This method multiplies the two values passed through
        /// </summary>
        /// <param name="a"> The value that we will multiply </param>
        /// <param name="b"> The amount of time we will multiply value 'a' </param>
        /// <returns> the total value of the operation </returns>
        public static double Multiply(double a, double b)
        {
            double total = a * b;
            return total;
        }

        /// <summary>
        /// This method divides the first value passed
        /// through by the second value
        /// </summary>
        /// <param name="a"> The numerator </param>
        /// <param name="b"> The Denominator </param>
        /// <returns> the result of the operation </returns>
        public static double Divide(double a, double b)
        {
            if ( b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }

            double total = a / b;
            return total;
        }
    }
}
