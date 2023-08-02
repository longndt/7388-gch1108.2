using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7B
{
    internal class UniversityStudent : Student 
    {
        private string universityName;
        private int universityRanking;

        public UniversityStudent(string studentName, string universityName, int universityRanking) : base(studentName)
        {
            this.universityName = universityName;
            this.universityRanking = universityRanking; 
        }

        public void display()
        {
            Console.WriteLine("Student name: " + getName());
            Console.WriteLine("University name: " + universityName);
            Console.WriteLine("University ranking: " + universityRanking);
        }
    }
}
