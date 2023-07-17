Console.WriteLine("Today is Monday");
Console.WriteLine("17/07/2023");
Console.Write(2023);
Console.WriteLine("University of Greenwich");

int a = 3;
int b = 6;
//comparison operator
Console.WriteLine("a > b : " + (a>b));
Console.WriteLine("a >= b : " + (a>=b));
Console.WriteLine(a < b);
Console.WriteLine(a <= b);
Console.WriteLine(a == b);
Console.WriteLine(a != b);


Console.Write("Enter your name: ");
String name = Console.ReadLine();
Console.Write("Enter your age: ");
int age =int.Parse(Console.ReadLine());
Console.Write("Are you married ? ");
bool married = bool.Parse(Console.ReadLine());
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Married: " + married);
Console.WriteLine("Name: {0} - Age: {1} - Married: {2}", name, age, married);