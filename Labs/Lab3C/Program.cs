double a = 10, b = 4;
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

double c = a / b;  //floating point/real number
int d = (int)(c);  //integer number
float e = (float)(d);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);
Console.WriteLine("e = {0:F1}", e);

double grade = 4.99999999;
double minToPass = 5.0;
bool check = true;
if (grade < minToPass)
    check = false;
if (check == true)
    Console.WriteLine("Pass");
else
    Console.WriteLine("Fail");
