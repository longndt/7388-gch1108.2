using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    //PROCEDURAL PROGRAMMING (lập trình thủ tục/lập trình hàm)
    internal class Demo
    {
        static int Total(int a, int b)
        {
            return a + b;
        }

        static void Main()
        {
            int x = Total(50,10);
            Console.WriteLine(x);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Hello(name);
        }

        static void Hello (string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
