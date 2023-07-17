int age;

do
{
    Console.Write("Enter your age (1-120): ");
    age = int.Parse(Console.ReadLine());
} while (age < 0 || age > 120);

Console.WriteLine("Hello. You are " +  age + " year old now !");

double grade;
do
{
    Console.Write("Enter your grade (0-10): ");
    grade = double.Parse(Console.ReadLine());
} while (grade < 0 || grade > 10);
if (grade >= 5)
    Console.WriteLine("Passed");
else
    Console.WriteLine("Failed");
