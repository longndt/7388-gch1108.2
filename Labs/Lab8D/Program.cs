//Email format: name@domain

using System.ComponentModel.DataAnnotations;

string email;
int total;
int length;
bool check1 = false;
bool check2 = false;

//1. validate email format: email must contain only 1 '@' symbol (not at 1st or last position)
//and must have '.' symbol
do
{
    Console.Write("Enter your email: ");
    email = Console.ReadLine();
    char[] emails = email.ToCharArray();
    length = emails.Length;
    total = 0;
    for (int i=0; i<length; i++) 
    {
        if (emails[i] == '@')
        {
            check1 = false;
            if (i == 0 || i == length - 1)
            {
                break;
            }     
            else
            {
                check1 = true;
                total++;
            }
        } 
        if (emails[i] == '.')
        {
            check2 = true;
        }
    }
} while (!email.Contains("@") || total > 1 || check1 == false || check2 == false || length < 5);


//2. split email components by '@' symbol
string[] components = email.Split("@");
Console.WriteLine("Email name: " + components[0]);
Console.WriteLine("Email domain: " + components[1]);
