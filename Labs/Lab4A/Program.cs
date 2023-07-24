//tạo array và gán giá trị cho các phần tử mà không cần khai báo kích thước (độ dài) của mảng
String[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

//Cách 1: in ra mảng sử dụng vòng lặp for (cần biết array length và phải khai báo biến index)
for (int i=0; i< dayOfWeek.Length; i++)
    Console.WriteLine(dayOfWeek[i]);

//Cách 2: in ra mảng sử dụng vòng lặp foreach (không cần biết length và không cần index)
foreach (String day in dayOfWeek)
    Console.WriteLine(day);
