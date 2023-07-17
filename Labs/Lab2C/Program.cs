Console.Write("Enter country name: ");
String country = Console.ReadLine();
//Method 1: use if else
if (country == "England" || country == "USA")
    Console.WriteLine("English");
else if (country == "Spain" || country == "Argentina" || country == "Mexico")
    Console.WriteLine("Spanish");
else
    Console.WriteLine("unknown");

//Method 2: use switch case
switch (country)
{
    case "England":
        Console.WriteLine("English");
        break;
    case "USA":
        Console.WriteLine("English");
        break;
    case "Spain":
        Console.WriteLine("Spanish");
        break;
    case "Argentina":
        Console.WriteLine("Spanish");
        break;
    case "Mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}
