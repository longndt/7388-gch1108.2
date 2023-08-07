Console.Write("Enter a string: ");
string s = Console.ReadLine();
Console.Write("Enter a word in string to be replaced: ");
string w1 = Console.ReadLine();
Console.Write("Enter new word to replace for old word: ");
string w2 = Console.ReadLine();
s = s.Replace(w1, w2);
Console.WriteLine(s);


char[] separators = new char[] {' ', ',', '.', '-', '*', '$', '#', '@' };
string text = "today * is @ monday. we # are $ - learning .net";
string[] words = text.Split(separators);
foreach (string word in words)
    Console.Write(word);