using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A
{
    internal class Demo
    {
        static void Main()
        {
            //declare an integer number (số nguyên)
            int a = 17;
            int b = 3;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;  // modulus: chia lấy phần dư
            // + : concatenation : dùng để nối
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + a + " + " + b + " = " + c);
            Console.WriteLine("a - b = " + d);
            Console.WriteLine("a * b = " + (a*b));
            Console.WriteLine("a / b = " + f);
            Console.WriteLine("a % b = " + a + " % " + b + " = " + g);
            
            //declare a floating number (số thực)
            double x = 7.5;
            float y = (float) (2.5);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x % y);

            //declare a String (text)
            String hanoi = "Ha Noi";
            String vietnam = "Viet Nam";
            Console.WriteLine(hanoi + " is the capital of " + vietnam);
            Console.WriteLine("We are living in " + hanoi);
            String year = "2023";
            //int year1 = 2023;
            String dob = "06/08/2000";

            //declare a character 
            char gender = 'f';
            char gender1 = 'm';
            Console.WriteLine("My gender is " + gender);

            //declare boolean (logic value: true or false)
            bool check = true;
            bool result = false;

            //1. declare variable without initialization
            int a1;
            a1 = 10;
            Console.WriteLine(a1);
            a1 = 20;  //override variable's value
            Console.WriteLine(a1);
            //2. declare variable with initialization 
            int b1 = 5;
        } 
    }
}
