using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = -4;
            int c = -6;

            CheckSign(a, b, c);
            Console.ReadLine();
        }

        public static bool CheckSign(int a, int b, int c)
        {
            bool sign = true;

            if (a == 0 || b == 0 || c == 0) // 0 or 0 or 0
            {
                Console.WriteLine("Does not compute to negative or positive.");
            }
            else if (a > 0 && b > 0 && c > 0) // + + +
            {
                Console.WriteLine("The product is '+'.");
                sign = true;
            }
            else if (a < 0 && b < 0 && c < 0) // - - -
            {
                Console.WriteLine("The product is '-'.");
                sign = false;
            }
            else if (a > 0 && b < 0 && c < 0) // + - -
            {
                Console.WriteLine("The product is '+'.");
                sign = true;
            }
            else if (a < 0 && b < 0 && c > 0) // - - +
            {
                Console.WriteLine("The product is '+'.");
                sign = true;
            }
            else if (a > 0 && b > 0 && c < 0) // + + -
            {
                Console.WriteLine("The product is '-'.");
                sign = false;
            }
            else if (a < 0 && b > 0 && c > 0) // - + +
            {
                Console.WriteLine("The product is '-'.");
                sign = false;
            }
            else if (a > 0 && b < 0 && c > 0) // + - +
            {
                Console.WriteLine("The product is '-'.");
                sign = false;
            }

            return sign;
        }
    }
}
