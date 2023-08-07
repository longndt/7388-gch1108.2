string mobiles = "iphone, samsung, htc, sony, xiaomi";
Console.WriteLine(mobiles.IndexOf("iphone"));  //0
Console.WriteLine(mobiles.IndexOf("samsung")); //8
Console.WriteLine(mobiles.IndexOf("nokia")); //-1
Console.Write("Enter a mobile brand: ");
string brand = Console.ReadLine().ToLower();
//brand = brand.ToLower();
if (mobiles.IndexOf(brand) != -1)
    Console.WriteLine("Found !");
else
    Console.WriteLine("Not found !");

string s = "Greenwich Vietnam";
string s1 = s.Substring(0, 9);  //start from index 0 and get 9 letters : Greenwich
Console.WriteLine(s1);
string s2 = s.Substring(10);    //start from index 10 and get until last letters: Vietnam
Console.WriteLine(s2);

Console.Write("Enter your full name (first name + last name): ");
string fullName = Console.ReadLine();  //get input from keyboard
string[] name = fullName.Split();  //split full name to first name + last name by space
Console.WriteLine("First name: " + name[0]);
Console.WriteLine("Last name: " + name[1]);


Console.Write("Enter your full name (first name + middle name + last name): ");
string fullName1 = Console.ReadLine();  //get input from keyboard
string[] name1 = fullName.Split();  //split full name to first name + middle name + last name by space
Console.WriteLine("First name: " + name1[0]);
Console.WriteLine("Last name: " + name[name1.Length-1]);

