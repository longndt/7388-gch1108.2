/*
 * String: many characters, double quote
 * Character: only 1 character, single quote
 */

String greenwich = "Greenwich Vietnam";
char c = '$';
Console.WriteLine(greenwich);
Console.WriteLine(c);

Console.Write("Enter your gender (M/F): ");
char gender = char.Parse(Console.ReadLine());
gender = char.ToUpper(gender);
if (gender == 'M')
{
    Console.WriteLine("You are male !");
} else if (gender == 'F')
{
    Console.WriteLine("You are female !");
} else
{
    Console.WriteLine("Invalid gender !");
}
