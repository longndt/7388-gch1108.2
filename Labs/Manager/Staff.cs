using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    //tạo OOP class để lưu toàn bộ thông tin của staff
    internal class Staff
    {
        public String Name { get ; set; }   
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public int Seniority { get; set; }
        public String Marriage { get; set; }
        public String Title { get; set; }   
        public String Gender { get; set; }  
        public String Address { get; set; } 
        public String StaffId { get; set; }

        public Staff(string name, DateTime birthday, int age, int seniority, string marriage, string title, string gender, string address, string staffId)
        {
            Name = name;
            Birthday = birthday;
            Age = age;
            Seniority = seniority;
            Marriage = marriage;
            Title = title;
            Gender = gender;
            Address = address;
            StaffId = staffId;
        }
    }
}
