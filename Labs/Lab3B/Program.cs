using System.Security.Cryptography;

double x1 = 3.14;
float x2 = (float)3.14;
float x3 = 3.14f;

Console.Write("Enter radius of circle: ");
double r = double.Parse(Console.ReadLine());
double area = Math.PI * r * r;
Console.WriteLine("Area of circle: {0:F12}", area);

double s1, s2, s3;
do
{
    Console.Write("Enter grade of student 1: ");
    s1 = double.Parse(Console.ReadLine());
} while (s1 < 0 || s1 > 10);
do
{
    Console.Write("Enter grade of student 2: ");
    s2 = double.Parse(Console.ReadLine());
} while (s2 < 0 || s2 > 10);
do
{
    Console.Write("Enter grade of student 3: ");
    s3 = double.Parse(Console.ReadLine());
} while (s3 < 0 || s3 > 10);
double avg = (s1 + s2 + s3) / 3;
Console.WriteLine("Average grade of all students: {0:F2}", avg);