using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6A
{
    internal class Student
    {
        //private: close
        //public: open

        //data/attributes (variables): private
        //operations/behaviours (methods) : public/private

        private String fullName;
        private DateTime birthday;
        private double grade;
        private int studentYear;
        private char gender;
        private bool graduated;

        public Student (string fullName, DateTime birthday, double grade, int studentYear, char gender, bool graduated)
        {
            //left: attribute | right: parameter
            this.fullName = fullName;
            this.birthday = birthday;
            this.grade = grade;
            this.studentYear = studentYear;
            this.gender = gender;
            graduated = this.graduated;
        }

        public void showStudentInfo()
        {
            Console.WriteLine("Full name: " +  fullName);
            Console.WriteLine("Birthday : " + birthday);
            Console.WriteLine("Grade    : " + grade);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Graduated: " + graduated);
            Console.WriteLine("Student year: " + studentYear);
        }
    } 
}
