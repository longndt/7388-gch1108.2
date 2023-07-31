using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6B
{
    internal class MobilePhone
    {
        //way 1: longer
        //attributes must be declares as 'private' : information hiding
        private String brandName;
        public String getBrandName()
        {
            return brandName;
        }
        public void setBrandName(String brandName) { 
            this.brandName = brandName;
        }

        //way 2: faster
        public String phoneModel { get; set; }
        public String color { get; set; }
        public double price { get; set; }
        public int stock { get; set; }

        //1 class may have 1 or many constructors
        //constructor must be declared as 'public' 
        public MobilePhone() { }
        public MobilePhone(String brand)
        {
            this.brandName = brand;
        }
        public MobilePhone (String brand, String model)
        {
            this.brandName = brand;
            this.phoneModel = model;
        }
        public MobilePhone(string brandName, string phoneModel, string color, double price, int stock)  
        {
            //"this" is compulsory in this case
            this.brandName = brandName;
            this.phoneModel = phoneModel;
            this.color = color;
            this.price = price;
            this.stock = stock;
        }

        public void showInfo()
        {
            //"this" is optional in this case
            Console.WriteLine("Brand name: " + this.brandName);
            Console.WriteLine("Phone model: " + this.phoneModel);
            Console.WriteLine("Phone color: " + this.color);
            Console.WriteLine("Phone price: " + this.price + "$");
            Console.WriteLine("In stock: " + this.stock);
        }
    }
}
