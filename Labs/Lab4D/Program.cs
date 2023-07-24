Console.Write("Enter total elements in array: ");
int total = int.Parse(Console.ReadLine());
int[] numbers = new int[total]; 
for (int i = 0; i < total; i++)
{
    Console.Write("Enter number " + (i+1) + " : ");
    numbers[i] = int.Parse(Console.ReadLine());
}
for (int i = total -1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}