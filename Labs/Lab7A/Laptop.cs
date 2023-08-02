using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7A
{
    internal class Laptop
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Laptop(double Price, string Name)
        {
            this.Price = Price;
            this.Name = Name;
        }

        public void show()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Price: " + Price + "$");
        }
    }
}
