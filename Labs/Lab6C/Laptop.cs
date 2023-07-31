using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6C
{
    internal class Laptop
    {
        public String Name { get; set; }
        public double Price { set; get; }
        public String Origin { get; set; }

        public Laptop(string name, double price)
        {
            Name = name;
            Price = price;
            Origin = "China";  //set default value
        }

        public void showLaptopInfo()
        {
            Console.WriteLine("Laptop name: " + Name);
            Console.WriteLine("Laptop price: " + Price + "$");
            Console.WriteLine("Laptop origin: " + Origin);
        }
    }
}
