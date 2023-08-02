using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7A
{
    internal class MobilePhone
    {
        public string BrandName { get; set; }
        public string PhoneModel { get; set; }
        
        public MobilePhone(string brandName, string phoneModel)
        {
            this.BrandName = brandName;
            this.PhoneModel = phoneModel;
        }

        public void displayPhone()
        {
            Console.WriteLine(BrandName + " " + PhoneModel);    
        }
    }
}
