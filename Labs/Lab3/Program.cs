int a = 3, b = 5; //global variable (biến toàn cục)
if (a <= b)  
{
    int c = 10; //local variable (biến cục bộ)
    Console.WriteLine(b);
}
//Console.WriteLine(c);
//error: local variable can be accessed inside local structure
Console.WriteLine(a);
//no error: global variable can be accessed everywhere

int x = 10; //declare and initialize variable at the same time
int y; //declare variable first
y = 15; //set value for variable later

int n = 2, m = 3; //declare same data type in 1 command 
//double d = 8.4, float f = (float) 9.2; //error: different data type

String outer = "I'm inside Main method";  //global
Console.WriteLine(outer);
for (int i=0; i<10; i++)
{
    String inner = "I'm inside For loop";  //local
    Console.WriteLine(inner);
}

byte centuries = 15;
ushort years = (ushort)(centuries * 100);
uint days = (uint) (years * 365);
ulong hours = days * 24;  //casting is unnecessary in this case
Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours + " hours");
Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours", centuries, years, days, hours);
