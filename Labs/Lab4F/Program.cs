List<int> numbers = new List<int>();
numbers.Add(2023);
numbers.Add(2040);
numbers.Add(2060);
numbers.Add(2080);

for (int i=0; i<numbers.Count; i++)
    Console.WriteLine(numbers[i]);

foreach (var n in numbers)
    Console.WriteLine(n);

List<String> students = new List<String>();
students.Add("Minh");
students.Add("Tuan");
students.Add("Hoang");
students.Add("Hung");
students.Add("Hoang");
students.Add("Hung");
students.Add("Hoang");
students.Add("Hung");
Console.Write("Enter student name: ");
String name = Console.ReadLine();
if (students.Contains(name))
    Console.WriteLine("True");
else
    Console.WriteLine("False");

Console.WriteLine("Total students: " + students.Count);
students.Remove(students[1]);  //remove 2nd student ("Tuan")
students.RemoveAt(4);          //remove 5th student (index = 4)
Console.WriteLine("Total students: " + students.Count);
students.Clear();
Console.WriteLine("Total students: " + students.Count);

List<int> nums = new List<int> {10, 20, 30, 40, 50};
nums.Add(60);
nums.Insert(3, 70);
foreach (int n in nums)  
    Console.WriteLine(n);
Console.WriteLine("------------");
nums.Sort();  //sort by ascending order (small to big)
foreach (int n in nums)
    Console.WriteLine(n);
Console.WriteLine("Max: " + nums.Max());
Console.WriteLine("Min: " + nums.Min());

