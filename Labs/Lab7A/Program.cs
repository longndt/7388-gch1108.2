using Lab7A;

List<MobilePhone> mobiles = new List<MobilePhone>();
List<Laptop> laptops = new List<Laptop>();
int choice = 0;
while (choice != 5)
{
    Console.WriteLine("1. Input Mobile");
    Console.WriteLine("2. Input Laptop");
    Console.WriteLine("3. Output Mobile");
    Console.WriteLine("4. Output Laptop");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Enter total mobiles: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter info of mobile " + (i + 1) + ":");
                Console.Write("Enter brand name: ");
                string brandName = Console.ReadLine();
                Console.Write("Enter phone model: ");
                string phoneModel = Console.ReadLine();
                MobilePhone mobile = new MobilePhone(brandName, phoneModel);
                mobiles.Add(mobile);
            }
            break;
        case 2:
            Console.Write("Enter total laptops: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter info of laptop " + (i + 1) + ":");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Laptop laptop = new Laptop(price, name);
                laptops.Add(laptop);
            }
            break;
        case 3:
            foreach (var mobile in mobiles)
            {
                mobile.displayPhone();
                Console.WriteLine("----------------");
            }
            break;
        case 4:
            foreach (var laptop in laptops)
            {
                laptop.show();
                Console.WriteLine("----------------");
            }
            break;
        case 5:
            Console.WriteLine("Goodbye. See you again !");
            break;
        default:
            Console.WriteLine("Invalid choice !");
            break;
    }
}




