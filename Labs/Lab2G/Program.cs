//print multiplication table (bảng cửu chương)

//method 1: using for loop
for (int i=1; i<=10; i++)
{
    for (int j=1; j<=10;j++)
    {
        Console.WriteLine(i + " * " + j + " = " + (i * j));
    }
    Console.WriteLine("------------");
}

//method 2: using while loop
/*
Console.Write("Enter a number (1-10): ");
int n = Console.Readline();
int x = 1;
while (x<=10)
{
    Console.WriteLine(n + " * " + x + " = " + (n * x));
    Console.WriteLine("------------");
    x++;
}
*/