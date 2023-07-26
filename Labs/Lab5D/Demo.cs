using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5D
{
    internal class Demo
    {
        static void Main()
        {
            Console.WriteLine(sum());       //no argument => use default value
            Console.WriteLine(sum(15, 20)); //has argument => override default value

            Console.Write("Enter a text: ");
            String text = Console.ReadLine();
            int number = 0;
            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine()); 
            } while (number < 1);
            RepeatString(text, number);
        }

        //assign default value for method's parameters
        static int sum(int x = 5, int y = 10)
        {
            return x + y;
        }

        static void RepeatString(String text, int number)
        {
            for (int i = 1; i<= number; i++) {
                Console.Write(text + " ");
            }
        }
    }
}
