string s1 = "Greenwich";
string s2 = "Vietnam";

//method 1: use "+" for string concatenation
string s3 = s1 + " " + s2;
Console.WriteLine(s3);

//method 2: use "string.Concat()" for string concatenation
string s4 = string.Concat(s1, " ", s2);
Console.WriteLine(s4);

s4 += " is an alliance program between Greenwich University & FPT University";
Console.WriteLine(s4);

//Problem A: Nhập vào 1 string và in string đấy ra console với số lần tương đương số ký tự của string
Console.Write("Enter a string: ");
string text = Console.ReadLine();
for (int i = 0; i < text.Length; i++)
{
    Console.Write(text);
}

//Problem B: Nhập vào 1 string array và in string đấy ra console với số lần tương đương số ký tự của string
Console.Write("\nEnter a string array: ");
string[] array = Console.ReadLine().Split(); //tách string theo space và lưu thành string array
foreach (string a in array)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a);
    }
}

