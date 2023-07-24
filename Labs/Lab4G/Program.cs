List<int> l1 = new List<int> { 50, 40, 60, 80, 15, 25, 10, 5 };
Console.Write("Unordered list: ");
foreach (int i in l1)
    Console.Write(i + " ");
Console.WriteLine();
Console.Write("Ascending list: ");
l1.Sort();
foreach (int i in l1)
    Console.Write(i + " ");
Console.WriteLine();
Console.Write("Descending list: ");
l1.Reverse();
foreach (int i in l1)
    Console.Write(i + " ");
Console.WriteLine();


List<String> students = new List<String>();
String name = null;
do
{
    Console.Write("Enter name: ");
    name = Console.ReadLine();
    if (name != "stop")
        students.Add(name);
} while (name != "stop");
//students.Remove(students.Last());
//students.RemoveAt(students.Count - 1);
foreach (var s in students)
    Console.WriteLine(s);

String demo = "10 20 15 25 40 35";
List<String> demo1 = demo.Split(' ').ToList();
List<int> demo2 = new List<int>();
for (int i=0; i<demo1.Count; i++)
{
    int demo3 = int.Parse(demo1[i]);
    demo2.Add(demo3);
}
foreach (var test in demo2)
    Console.WriteLine(test);
   