using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;//default value is not a number if operation could result in a error
            //using switch statement to do the math
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    //ask user to enter non-zero divisor
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    //return text for incorrect option entry
                    break;
            }
            return result;
        }
    }
}
