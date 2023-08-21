using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        public string Name { get; set; }    
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }

        public Contact() { }
        public Contact(string name, string mobile, string address, string image)
        {
            Name = name;
            Mobile = mobile;
            Address = address;
            Image = image;
        }   
    }
}
