using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7B
{
    internal class CollegeStudent : Student
    {
        private string collegeName;
        private string collegeAddress;

        public CollegeStudent (string collegeName, string collegeAddress, int studentID) : base (studentID)
        {
            this.collegeName = collegeName;
            this.collegeAddress = collegeAddress;
        } 
    }
}
