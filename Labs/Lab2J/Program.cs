int hour, minute;
do
{
    Console.Write("Enter hour (0-23): ");
    hour = int.Parse(Console.ReadLine());
    Console.Write("Enter minute (0-59): ");
    minute = int.Parse(Console.ReadLine());
} while (hour < 0 || hour > 23 || minute < 0 || minute > 59);
Console.WriteLine("Current time: " + hour + ":" + minute);

minute += 30;  // increase 30 minutes

int h = minute / 60;
if ((hour + h) < 24)
    hour += h;
else
    hour = h - 1;

int m = minute % 60;
if ((minute + m) < 60)
    minute += m;
else
    minute = m;

Console.WriteLine("New time (after 30 mins): " + hour + ":" + minute);


