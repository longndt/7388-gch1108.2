using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace: tên project
namespace Lab5
{
    //class: tên file class (C#)
    internal class Lab5
    {
        //hàm (function) Main: hàm quan trọng nhất => dùng để chạy code
        static void Main()
        {
            //gọi hàm (invoke method). Note: có thể gọi nhiều lần => code reuse
            SayHello();
            SayHello();
            SayHello();

            /*
             * Khi truyền vào đối số lúc gọi hàm cần thỏa mãn 3 điều kiện:
             * 1. cùng số lượng  : số lượng đối số phải đúng với số lượng tham số
             * 2. cùng kiểu dữ liệu : kiểu dữ liệu của đối số phải trùng với kiểu dữ liệu của tham số
             * 3. đúng thứ tự : thứ tự của đối số phải khơp với thứ tự của tham số
             */
            double c = total(10.5, 20);  //10, 20: argument (đối số)
            c *= 5;
            Console.WriteLine(c);
            // Console.WriteLine(total(10,20));

            Console.WriteLine(Welcome("Hoang Minh Tu"));
        }

        //khai báo hàm (declare method): kiểu trả về là void (không có return) & không có tham số (parameter)
        //cần phải khai báo từ khóa static để có thể được gọi trong hàm Main
        static void SayHello()
        {
            Console.WriteLine("Hello world !");
            Console.WriteLine("We are from Greenwich Vietnam");
            Console.WriteLine("We are learning Programming");
            Console.WriteLine("Language: C#");
            Console.WriteLine("Platform: .NET");
        }

        /* 
         *    method name (tên hàm): total   
         *    return type (kiểu trả về): int (integer)
         *    parameters (tham số): a & b
         */
        static double total (double a, int b)
        {
            //int c = a + b;
            //return c;
            return a + b;  //int
        }

        static String Welcome(String name)
        {
            String s = "Welcome " + name + " to Greenwich Vietnam !";
            return s;
        }
    }
}
