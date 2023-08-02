using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7B
{
    //use ":" symbol for inheritance
    internal class Employee : Person
    {
        private string company;
        private int birthYear;

        public Employee (string name, int birthYear, string company) : base(name)
        {
            this.company = company;
            this.birthYear = birthYear;
        }

        public void display()
        {
            Console.WriteLine("Employee Name:  " + getName());
            Console.WriteLine("Company Name:  " + company);
            Console.WriteLine("Birthyear:  " + birthYear);
        }
    }
}
