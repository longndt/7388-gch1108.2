using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5F
{
    internal class Program
    {
        static void Main()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Integer");
                Console.WriteLine("2. Character");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine()); 
            } while (choice < 1 || choice > 2);   
            if (choice == 1)
            {
                Console.Write("Enter 1st integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd integer: ");
                int b = int.Parse(Console.ReadLine());  
                Console.WriteLine(GetMax(a, b));
            } else if (choice == 2)
            {
                Console.Write("Enter 1st character: ");
                Char a = Char.Parse(Console.ReadLine());
                Console.Write("Enter 2nd character: ");
                Char b = Char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }

        static char GetMax(char a, char b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }
    }
}
