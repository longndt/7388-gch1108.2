using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7C
{
    internal class MainProgram
    {
        static List<Person> people = new List<Person>();
        static List<Student> students = new List<Student>();

        static void Main()
        {
            inputStudent();
            sortGrade();
            Console.WriteLine("Student list sorted by grade descending (High - Low): ");
            outputStudent();

            /* input();
            Console.WriteLine("PEOPLE LIST BEFORE SORT");
            output(people);
            Console.WriteLine("PEOPLE LIST AFTER SORT");
            var sorted_list = sort();
            output(sorted_list); */
        }

        static void inputStudent()
        {
            Console.Write("Enter total students: ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter information of student " + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                double grade;
                do
                {
                    Console.Write("Grade: ");
                    grade = double.Parse(Console.ReadLine());
                } while (grade < 0 || grade > 10);
                Student student = new Student(name, grade);
                students.Add(student);
            }
        }

        static void sortGrade()
        {
            students = students.OrderBy(s => s.Grade).Reverse().ToList(); 
        }

        static void outputStudent()
        {
            foreach (var student in students)
            {
                student.showInfo();
            }
        }

        static void input()
        {
            Console.Write("Enter total person: ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter information of person " + (i + 1));
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(firstName, lastName, age);
                people.Add(person);
            }
        }

        static void output(List<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person.toString());
            }
        }

        static List<Person> sort()
        {
            var sorted_people = people.OrderBy(person => person.FirstName)
                .ThenBy(person => person.Age).ToList();
            return sorted_people;
        }
    }
}
