Console.Write("Enter your name: ");
String name = Console.ReadLine();
Console.Write("Enter your grade: ");
double grade = double.Parse(Console.ReadLine());

/* 
if (grade >= 5.0)
{
    Console.WriteLine("Congratulations to " + name);
    Console.WriteLine("You have passed the exam !");
} else {  // grade < 5.0
    Console.WriteLine("Bad luck for " + name);
    Console.WriteLine("You have failed the exam !");
} 
*/

/*
 * 1 condition: if
 * 2 conditions: if + else
 * >2 conditions: if + else if + else
 */

/*
 * and : &&
 * or  : ||
 */

/* Grading range:
 * <0 || >10 : Invalid grade (else)
 * 0   - 4.9  : Refer (else if)
 * 5.0 - 7.9  : Pass (else if)
 * 8.0 - 8.9  : Merit (else if)
 * 9.0 - 10.0 : Distinction (if)
 */

if (grade >= 9.0 && grade <=10.0)
{
    Console.WriteLine("Distinction");
} 
else if (grade >= 8.0 && grade <= 8.9)
{
    Console.WriteLine("Merit");
}
else if (grade >= 5.0 && grade <= 7.9)
{
    Console.WriteLine("Pass");
} 
else if (grade >= 0 && grade <= 4.9)
{
    Console.WriteLine("Refer");
}
else  // grade <0 || grade>10
{
    Console.WriteLine("Invalid grade !");
}



