using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Demo
    {
        static void Main()
        {
            /*
              * Đoạn code này giới thiệu về cách thức 
              * in nội dung ra màn hình
              * Cần lưu ý về sự khác biệt giữa Write và WriteLine
              */

            /*
             * Mục đích của việc viết comment trong code
             * 1. Giải thích code
             * 2. Vô hiệu hóa code
             */

            //Write: in ra console nhưng không xuống hàng
            //WriteLine: in ra console và xuống hàng
            Console.Write("University of Greenwich");
            Console.Write(" - Vietnam");
            //In ra text thì cần có dấu nháy kép
            Console.WriteLine("Programming - 7388");
            //In ra số thì không cần dấu nháy kép
            Console.WriteLine(2023);
        }
    }
}
