using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    //1. declare class name
    internal class Birthday
    {
        //2. declare class attribute(s): variables
        private int Day;
        private int Month;
        private int Year;

        //3. declare class operation(s): methods
        //3A. declare constructor (hàm khởi tạo)
        /* public Birthday (int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }*/

        //constructor: special method (method name == class name, no return type)
        public Birthday (int y, int m, int d)
        {
            Month = m;
            Day = d;
            Year = y;   
        }


        //empty constructor
        public Birthday()
        {
        }

        //3B. declare other methods
        public void printBirthday()
        {
            Console.WriteLine(Day + "/" + Month + "/" + Year);
        }
        public void addDay (int day)
        {
            Day += day;
        }

        //setters: set values
        public void setDay(int d)
        {
            Day = d;
        }
        public void setMonth(int m)
        {
            Month = m;
        }
        public void setYear(int y)
        {
            Year = y;
        }

        //getters: get values
        public int getMonth()
        {
            return Month;
        }

        public int getYear()
        {
            return Year;
        }

        public int getDay()
        {
            return Day;
        }
    }
}
