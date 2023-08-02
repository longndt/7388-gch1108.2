using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7B
{
    //derived/inherited class (child class)
    internal class Student : Person
    {
        private int studentID;

        public Student(int studentId)
        {
            this.studentID = studentId;
        }

        public Student(string name) : base (name)
        {
        }

        public Student (string name, int age, int studentId) : base(name, age)
        {
            this.studentID = studentId;
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Student ID: " + studentID);
        }

        public void doHomework()
        {
            Console.WriteLine("Student do homework and submit to CMS");
        }
    }
}
