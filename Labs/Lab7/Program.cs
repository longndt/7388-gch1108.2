
using Lab7;

//create new objects (class instances)
DateTime dob1 = new DateTime(2000, 5, 15);
Student student1 = new Student(123, "Minh", dob1, 3.8);
DateTime dob2 = new DateTime(2000, 7, 24);
Student student2 = new Student(888, "Tuan", dob2, 5.8);

student1.showStudentInfo();
if (student1.getGrade() >= 5.0)
{
    Console.WriteLine("Passed !");
} else
{
    Console.WriteLine("Failed !");
}

student1.setGrade(6.8);
Console.WriteLine("Updated grade for student 1. New grade: " + student1.getGrade());

if (student1.getGrade() >= 5.0)
{
    Console.WriteLine("Passed !");
}
else
{
    Console.WriteLine("Failed !");
}

student2.showStudentInfo();

Console.WriteLine("Welcome " + student2.getName() + " to Greenwich Vietnam !");

Student student3 = new Student();
student3.setName("Hoang");
student3.setDob(new DateTime(1999, 6, 19));
student3.setGrade(5.6);
student3.setStudentID(9999);
student3.showStudentInfo();

student3.doHomework();

