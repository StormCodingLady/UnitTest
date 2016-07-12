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
            int a = 0;
            int b = 0;
            int c = 0;
            int intInput;
            bool noError = false;
            bool noError2 = false;
            bool noError3 = false;
            
            while (noError == false)
            {
                Console.WriteLine("Integer 'a' equals...");
                Console.WriteLine("(Enter an integer from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out intInput);
                if (isInt)
                {
                    a = intInput;
                    noError = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }

            }

            while (noError2 == false)
            {
                Console.WriteLine("Integer 'b' equals...");
                Console.WriteLine("(Enter an integer from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out intInput);
                if (isInt)
                {
                    b = intInput;
                    noError2 = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }

            }

            while (noError3 == false)
            {
                Console.WriteLine("Integer 'c' equals...");
                Console.WriteLine("(Enter an integer from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out intInput);
                if (isInt)
                {
                    c = intInput;
                    noError3 = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }
            }



            int answer = CheckValue(a, b, c);
            missionReport(answer); //get output
            Console.ReadLine();
        }

        public static void missionReport(int answer)
        {
                Console.WriteLine("The highest number is '{0}'.", answer);
        }
        

        public static int CheckValue(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a; 
            }
            else
            {
                if (b >= c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }    
    }
}


