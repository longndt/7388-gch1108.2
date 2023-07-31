using Lab6;

//1. create new objects (class instances) using constructor
Birthday test = new Birthday();
test.setDay(25);
test.setMonth(9);
test.setYear(1996);
test.printBirthday();

Birthday birthday1 = new Birthday(2000, 5, 15);
birthday1.printBirthday();
Console.WriteLine("Changed to new day: 25");
birthday1.setDay(25);
birthday1.printBirthday();

Birthday birthday2 = new Birthday(1999, 12, 30);
birthday2.printBirthday();

int day, month, year;
do
{
    Console.Write("Enter day: ");
    day = int.Parse(Console.ReadLine());
} while (day < 1 || day > 31);

do { 
    Console.Write("Enter month: ");
    month = int.Parse(Console.ReadLine());
} while (month < 1 || month > 12);

do {
    Console.Write("Enter year: ");
    year = int.Parse(Console.ReadLine());
} while (year < 1900 || year > 2023);
Birthday bd = new Birthday(year, month, day);
bd.printBirthday();
/*
 * Note: khi khởi tạo object và truyền tham số vào object
 * thì phải thỏa mãn 3 điều kiện như sau:
 * 1. đúng số lượng
 * 2. đúng kiểu dữ liệu
 * 3. đúng thứ tự
 */

Birthday demo = new Birthday(2000, 3, 19);
Console.WriteLine("Original Birthday: ");
demo.printBirthday();
demo.addDay(6);
Console.WriteLine("New Birthday: ");
demo.printBirthday();

/* Note: lúc gọi hàm thì không cần phải theo thứ tự
 * khai báo hàm của Class đã tạo
 */
Console.WriteLine("Day: " + demo.getDay());
Console.WriteLine("Month: " + demo.getMonth());
Console.WriteLine("Year: " + demo.getYear());
