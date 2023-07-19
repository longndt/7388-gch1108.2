int n;
do
{
    Console.Write("Enter a number (10-99): ");
    n = int.Parse(Console.ReadLine());
} while (n < 10 || n > 99);

for (int i = 1; i <= n; i++)
{
    bool special = false;
    if (i < 10)        //number contains 1 digit
    {
        if (i == 5 || i == 7)
        {
            special = true;
        }
    }
    else              //number contains 2 digits
    {
        int d1 = i / 10;  //get 1st digit
        int d2 = i % 10;  //get 2nd digit
        int sum = d1 + d2;
        if (sum == 5 || sum == 7 || sum == 11) { 
            special = true;
        }
    }
    Console.WriteLine(i + "->" + special);
}
