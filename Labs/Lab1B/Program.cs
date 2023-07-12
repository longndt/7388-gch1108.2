String name;
/* int age;
int yob;
int current_year; */
int age, yob, current_year;  //declare multiple variables with same data type
Console.Write("Input your name: ");
name = Console.ReadLine();  //default return type of ReadLine() is String
Console.Write("Input your age: ");
age = int.Parse(Console.ReadLine());  //type casting
current_year = DateTime.Now.Year;
yob = current_year - age;
Console.Write("Hello " + name + " ! ");
// Write + "\n"  <===>  WriteLine
Console.Write("You are " + age + " year old now." + "\n");
Console.WriteLine("You was born in " + yob);

Console.WriteLine("Enter grade of subject 1: ");
double subject1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter grade of subject 2: ");
double subject2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter grade of subject 3: ");
double subject3 = Double.Parse(Console.ReadLine());
double average_grade = (subject1 + subject2 + subject3) / 3;
//double averageGrade = (subject1 + subject2 + subject3) / 3;
Console.WriteLine("Subject 1: {0} - Subject 2: {1} - Subject 3: {2}", subject1, subject2, subject3);
Console.WriteLine("Average grade of all subjects: {0:F1}", average_grade);
