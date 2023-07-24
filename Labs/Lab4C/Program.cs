//1. input string
Console.WriteLine("Enter list of numbers in string (separated by space): ");
String s = Console.ReadLine();
//2. split string into string array
String[] s1 = s.Split();
//3. create int array which length equals to string array's length
int[] array = new int[s1.Length];
//4. convert string array to int array
int total = 0;
for (int i=0; i<array.Length; i++)
{
    array[i] = int.Parse(s1[i]);
    total+= array[i];
}
//5. print int array with foreach loop
foreach (int number in array)
    Console.WriteLine(number);   

Console.WriteLine("Total: " + total);

String s123 = Console.ReadLine();
String[] s321 = s123.Split('$');
foreach (String s888 in s321) 
    Console.WriteLine(s888);

String paragraph = Console.ReadLine();
String[] sentences = paragraph.Split('.');
foreach (String sen in sentences)
    Console.WriteLine(sen);