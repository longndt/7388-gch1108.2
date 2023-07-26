using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab5A
{
    internal class Demo
    {
        static void Main()
        {
            double x;
            do
            {
                Console.Write("Enter x: ");
                x = double.Parse(Console.ReadLine());
            } while (x < 0 || x > 10);
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            int choice = 0;  //0: default value of integer number
            while (choice !=3) 
            {
                Console.WriteLine("1. Multiplication");
                Console.WriteLine("2. Division");
                Console.WriteLine("3. Exit program");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(x + " * " + y + " = {0:F2}", Multiplication(x, y));
                        break;
                    case 2:
                        Console.WriteLine(x + " / " + y + " = {0:F2}", Division(x, y));
                        break;
                    case 3:
                        Console.WriteLine("Goodbye. See you later !");
                        break;
                    default:
                        Console.WriteLine("Invalid choice !");
                        break;
                }
            }   
        }

        static double Multiplication (double a, double b)
        {
            return a * b;
        }

        static double Division (double a, double b)
        {
            return a / b;
        }
    }
}
