/* 
for (int i = 2; i <= 20; i++)
{
    if (i % 2 == 0)   //even number
        Console.WriteLine(i);
}

for (int i=1; i<=20; i++) { 
  if (i % 2 == 0)   //even number
    Console.WriteLine(i);
}

for (int i = 2; i <= 20; i+=2)
     Console.WriteLine(i);

for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0) //odd number
        Console.WriteLine(i);
}
*/

int total = 0;
for (int i = 1; i <= 50; i += 2)
{
    Console.WriteLine(i);
   // total = total + i;
    total += i;
}
Console.WriteLine("Total: " + total);
    