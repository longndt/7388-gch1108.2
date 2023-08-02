using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7B
{
    //base class (parent class)
    internal class Person
    {
        private string name;
        private int age;
        private string nationality;

        public Person() { }
        public Person(string name)
        {
            //this: represent for class name
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality; 
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
        public string getName() {
            return name;
        }
    }
}
