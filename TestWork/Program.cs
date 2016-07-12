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
            int a = 6;
            int b = 4;
            int c = 2;

            Console.ReadLine();   
        }

        public static bool CheckValue(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("Integer 'a' is largest.");
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Integer 'b' is largest.");
                }
                else
                {
                    Console.WriteLine("Integer 'c' is largest.");
                }
            }
        }
    }

    public class SnowMan
    {
        static private int sizeOfNose;
        bool changeMe;

        public string ThrowRock(int a, string bravo)
        {
            return "hello";
        }

        static public int TossStone(string hey, int b)
        {
            return 2;
        }

        public void GoCrazy()
        {
            changeMe = !changeMe;
            return;
        }
    }
}
