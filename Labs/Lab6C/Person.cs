using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6C
{
    internal class Person
    {
        public String Name { get; set; }
        public Laptop Laptop { get; set; }

        public Person(String name, Laptop laptop)
        {
            Name = name;
            Laptop = laptop;
        }

        public void showPersonInfo()
        {
            Console.WriteLine("Person name: " + Name);
            Laptop.showLaptopInfo();
        }
    }
}
