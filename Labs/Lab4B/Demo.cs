using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4B
{
    internal class Demo
    {
        public static void Main()
        {
            total(15, 35, 68);
            for (int i=0; i<50; i++)
            {
                hello();
            }
        }

        public static void hello()
        {
            Console.WriteLine("Hello world");
        }

        public static void total (int a, int b, int c)
        {
            Console.WriteLine("Total: " + (a + b + c));
        }
    }
}
