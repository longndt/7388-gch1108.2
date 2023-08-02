using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6C
{
    /*
     * Comment for file header:
     * This is class "Laptop"
     * - attributes: Name, Price, Origin
     * - methods: constructor, showLaptopInfo(), getters, setters
     */
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

        /*
         * Comment for function header:
         * This function (method) is used to display laptop information
         */
        public void showLaptopInfo()
        {
            Console.WriteLine("Laptop name: " + Name);
            Console.WriteLine("Laptop price: " + Price + "$");
            Console.WriteLine("Laptop origin: " + Origin);
        }
    }
}
