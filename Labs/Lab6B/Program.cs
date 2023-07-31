using Lab6B;

MobilePhone phone1 = new MobilePhone("Apple", "iPhone 14 Pro Max", "Black",
    1299.99, 20);
phone1.showInfo();

MobilePhone phone2 = new MobilePhone("Samsung");
phone2.phoneModel = "Galaxy S23 Ultra";
phone2.color = "White";
phone2.price = 1111.11;
phone2.stock = 15;
phone2.showInfo();

MobilePhone phone3 = new MobilePhone("HTC", "One Max");
phone3.color = "Grey";
phone3.price = 888.88;
phone3.stock = 12;
phone3.showInfo();

Console.WriteLine("Price of Samsung phone: " + phone2.price + "$");
