//find and remove word from string
using System;

Console.Write("Enter a text: ");
string t = Console.ReadLine();
Console.Write("Enter a word: ");
string w = Console.ReadLine();
//tìm word 'w' trong text 't' : -1 (not found), !-1 (found, return first index);
int index = t.IndexOf(w);
int total = 0;
Console.WriteLine("Initial Length: " + t.Length);
//chạy vòng lặp while để tìm và xóa tất cả các word trong string
while (index != -1)
{
    total++;
    t = t.Remove(index, w.Length); //xóa word khỏi text
    index = t.IndexOf(w); //reset lại index của word
}
Console.WriteLine("Current Length: " + t.Length);
Console.WriteLine("Total word found: " + total);    
Console.WriteLine("Text after removed word: " + t);

//find word from string
Console.Write("Enter a text: ");
string text = Console.ReadLine();
Console.Write("Enter a word to search: ");
string word = Console.ReadLine();
if (text.Contains(word))
    Console.Write("Word found !");
else
    Console.Write("Word not found !");