using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5E
{
    internal class Demo
    {
        static void Main() { 
            Console.WriteLine(total(6, 8, 15));
            Console.WriteLine(total(5, 7));
            Console.WriteLine(total(3.5, 9.6));
            Console.WriteLine(total(10, 15.5));
        }

        //overloading methods: các hàm cùng tên nhưng khác số lượng/kiểu dữ liệu của tham số hoặc/và kiểu trả về
        static int total (int a, int b, int c)
        {
            return a + b + c;
        }
        static int total (int a, int b)
        {
            return a + b;
        }

        static double total (double a, double b) 
        { 
            return a + b;
        }

        static double total(int a, double b)
        {
            return a + b;
        }
    }
}
