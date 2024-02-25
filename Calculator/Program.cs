using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
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
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Console calculator in C#\r");
            Console.WriteLine("--------------------------");

            while (!endApp)
            {
                string num1 = "";
                string num2 = "";
                double result = 0;

                //check for characters and strings later
                Console.WriteLine("Type a number, and then press enter");
                num1 = Console.ReadLine();
                double cleanNum1 = 0;
                while(!double.TryParse(num1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid input, please enter an integer value");
                    num1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number, and then press enter");
                num2 = Console.ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(num2, out cleanNum2))
                {
                    Console.WriteLine("This is not a valid input, please enter an integer value");
                    num2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operation from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("What's it gonna be?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error. \n");
                    }
                    else Console.WriteLine("Your Result: {0:0.##}\n", result);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Oh Nein, einen exception macht. Trying to do the math.\n - Details:" + e.Message);
                }
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("Press 'x' to close the console app...Press any other key and Enter to continue");
                if (Console.ReadLine() == "x") endApp = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
