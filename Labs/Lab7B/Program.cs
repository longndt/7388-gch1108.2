using Lab7B;
using System.Security.Cryptography;

Person p1 = new Person("Tien", 20);
p1.display();

Student s1 = new Student("Hung", 19, 12345);
s1.display();
s1.doHomework();

Employee e1 = new Employee("Tuan", 1996, "FPT");
e1.display();

CollegeStudent cs1 = new CollegeStudent("FPT Polytech", "Hanoi", 123);
cs1.display();

UniversityStudent us1 = new UniversityStudent("FPT Greenwich", "Pham Van Bach", 10);
us1.display();