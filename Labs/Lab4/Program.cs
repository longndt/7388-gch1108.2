//declare an array
using System.ComponentModel.DataAnnotations;

int[] numbers = new int[5]; //array name: numbers, array length: 5

//assign value for each element in array
numbers[0] = 10;   //first element, index = 0 (always)
numbers[1] = 15;
numbers[4] = 25;   //last element, index = array length - 1 = 4
numbers[2] = 50;
numbers[3] = 55;
//numbers[10] = 100;  //runtime error: index was out of bound

//print value for each element
Console.WriteLine("numbers[2] = " + numbers[2]);  //print 3rd element
Console.WriteLine("numbers[3] = " + numbers[3]);  //print 4th element
//Console.WriteLine("numbers[10] = " + numbers[10]);  //runtime error

Console.Write("Enter total students in class: ");
int length = int.Parse(Console.ReadLine());
double[] grade = new double[length];
double total = 0, average = 0;
double min = 0, max = 0;
for (int i = 0; i <= length - 1; i++)
{
    do
    {
        Console.Write("Enter grade of student " + (i + 1) + " : ");
        grade[i] = double.Parse(Console.ReadLine());
    } while (grade[i] < 0 || grade[i] > 10);
}
min = grade[0];
max = grade[0];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Grade of student " + (i + 1) + " : " + grade[i]);
    total+= grade[i];
    if (grade[i] > max)
        max = grade[i];
    if (grade[i] < min)
        min = grade[i];
}
average = total / length;
Console.WriteLine("Average grade: {0:F2}", average);
Console.WriteLine("Min grade: " + min);
Console.WriteLine("Max grade: " + max);