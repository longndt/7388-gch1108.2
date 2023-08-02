using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    //OOP class
    internal class Student
    {
        //1. attributes (variables)
        //always set access modifier of attribute as "private" due to information hiding policy
        private int studentID;
        private string name;
        private DateTime dob;
        private double grade;

        //2. operations (methods)
        //2A. constructor: hàm khởi tạo
        //special method: method name is similar to class name, no return type
        public Student() { }   //empty constructor
        public Student (int studentID, DateTime birthday)
        {
            //case 1: variable name & parameter name are similar => use "this" keyword
            //this => refer to class name
            this.studentID = studentID;
            //case 2: variable name & parameter name are different => no need to use "this" keyword
            dob = birthday;
        }
        public Student (int studentID, string name, DateTime dob, double grade)
        {
            this.studentID=studentID;
            this.name = name;   
            this.dob = dob;
            this.grade = grade;
        }

        //2B. getter (read only) + setter (write)
        public string getName()
        {
            return name;
        }
        public double getGrade()
        {
            return grade;
        }
        public void setName (string name)
        {
            this.name = name;
        }

        public void setStudentID (int id)
        {
            studentID = id;
        }
        public void setGrade(double newGrade)
        {
            grade = newGrade; 
        }

        public void setDob (DateTime dob)
        {
            this.dob = dob; 
        }

        //2C. other methods
        public void doHomework()
        {
            Console.WriteLine("Student must do homework and submit before deadline");
        }

        public void showStudentInfo()
        {
            Console.WriteLine("Student ID: " +  studentID);
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student dob: " + dob);
            Console.WriteLine("Student grade: " + grade);
        }


    }
}
