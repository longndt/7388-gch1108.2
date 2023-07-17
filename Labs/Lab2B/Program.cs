Console.Write("Enter a month (in number): ");
int month = int.Parse(Console.ReadLine());

/*
 if (month == 1)
{
    Console.WriteLine("January");
} else if (month == 2)
{
    Console.WriteLine("February");
}
else if (month == 3)
{
    Console.WriteLine("March");
}
*/

// switch case
switch(month)
{
    case 1:  //if
        Console.WriteLine("January");
        break;
    case 2:  //else if
        Console.WriteLine("February");
        break;
    case 3: //else if
        Console.WriteLine("March");
        break;
    case 4: //else if
        Console.WriteLine("April");
        break;
    case 5:  //else if
        Console.WriteLine("May");
        break;
    case 6: //else if
        Console.WriteLine("June");
        break;
    case 7: //else if
        Console.WriteLine("July");
        break; 
    case 8:  //else if
        Console.WriteLine("August");
        break;
    case 9: //else if
        Console.WriteLine("September");
        break;
    case 10:  //else if
        Console.WriteLine("October");
        break;
    case 11: //else if
        Console.WriteLine("November");
        break;
    case 12:  //else if
        Console.WriteLine("December");
        break;
    default:  //else
        Console.WriteLine("Invalid month");
        break;
}
