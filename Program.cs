/*
 * Math Functions
 * Pawelski
 * 2/1/2022
 * Read over the code and run the program a few times to determine
 * what the program does and how it works. Once you understand the
 * program, answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Power(3, 2));
            Console.WriteLine();

            int userNumber;
            long result;
            Console.Write("Enter a number >> ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            result = Factorial(userNumber);
            Console.WriteLine(userNumber + "! = " + result);
        }

        /*
         * The Power method calculates x to the power of n.
         * x represents the base
         * n represents the exponent or power
         * returns x to the power of n
         */
        private static double Power(double x, int n)
        {
            double power = 1;
            for(int i = 0; i < n; i++)
            {
                power *= x;
            }
            return power;
        }

        /*
        * The Factorial method calculates the product of all the positive
        * integers less than or equal to n.
        * n represents the the base, must be a positive integer
        * returns the factorial
        */
        private static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
