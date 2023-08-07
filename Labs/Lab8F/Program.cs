Console.Write("Enter a text: ");
string text = Console.ReadLine();
Console.Write("Enter a list of banned words: ");
string[] word = Console.ReadLine().Split();
string replaced = "*****";
foreach (string w in word)
{
    if (text.Contains(w))
        text = text.Replace(w, replaced);
}
Console.WriteLine(text);