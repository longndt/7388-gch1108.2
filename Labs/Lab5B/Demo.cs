using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5B
{
    internal class Demo
    {
        static void Main()
        {
            int n = GetInput();
            CheckSignOfInteger(n);
            Console.WriteLine(CheckEvenOddNumber(n));
        }

        static int GetInput()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        static String CheckEvenOddNumber (int n)
        {
            if (n % 2 == 0)
            {
                return n + " is even number";
            } else
            {
                return n + " is odd number";
            }
        }

        static void CheckSignOfInteger (int n)
        {
            if (n == 0)
            {
                Console.WriteLine(n + " is zero");
            } else if (n > 0)
            {
                Console.WriteLine(n + " is positive integer");
            } else  //n < 0
            {
                Console.WriteLine(n + " is negative integer");
            }
        }



        /* static void Text()
        {
            Console.WriteLine("This is a text");
            Number();  //invoke method inside another method (not Main method)
        }

        static void Number()
        {
            Console.WriteLine("This is a number");
        }
        */
    }
}
