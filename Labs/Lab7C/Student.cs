using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7C
{
    internal class Student : Person
    {
        public double Grade { get; set; }   

        public Student (string name, double grade) : base (name)
        {
            Grade = grade;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + FirstName);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
