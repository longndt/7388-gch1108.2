using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5C
{
    internal class Lab
    {
        static void Main()
        {
            double grade;
            do
            {
                Console.Write("Enter grade (2.0 => 6.0): ");
                grade = double.Parse(Console.ReadLine());
            } while (grade < 2.00 || grade > 6.00);

            CheckGrade(grade);
        }

        private static void CheckGrade(double grade)
        {
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.Write("Excellent");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.Write("Very good");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.Write("Very good");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.Write("Good");
            }
            else
            {
                Console.Write("Poor");
            }
        }
    }
}
