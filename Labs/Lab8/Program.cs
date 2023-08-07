//character (char): single character, using single quote
char c1 = 'g';
Console.WriteLine(c1);

//string: many characters, using double quote
//string: an array of characters
String s1 = "Greenwich University";
string s2 = "So 2 Pham Van Bach - Cau Giay - Ha Noi";
string s3 = "!@$%^&*()";
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
//using + (addition symbol) for string concatenation
Console.WriteLine(s1 + ". " + s2);

string s4 = "GCH1108";
Console.WriteLine(s4);
s4 = "GCH1109";
Console.WriteLine(s4);
Console.WriteLine("s4[5] = " + s4[5]);  //index 5 => character at position 4
//s4[5] = 8;  //assignment error: can not change by another value

//Method 1: declare a string as a normal text
String s5 = "Greenwich";
Console.WriteLine(s5);
//convert string to character array
char[] c5 = s5.ToCharArray(); 

//Method 2: declare a string as an array of character
String s6 = new string(new char[] { 'G', 'r', 'e', 'e', 'n', 'w', 'i', 'c', 'h' });
Console.WriteLine(s6);

//Task: Nhập vào một string và đếm có bao nhiêu nguyên âm (vowel), phụ âm (consonant), ký tự đặc biệt (special symbol)
//và khoảng cách (space)
Console.Write("Enter a string: ");
string text = Console.ReadLine();
char[] texts = text.ToCharArray();
int total_vowel = 0, total_space = 0, total_symbol = 0, total_consonant = 0;
foreach (char n in text)
{
    if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
        total_vowel++;
    else if (n == ' ')
        total_space++;
    else if (n == '!' || n == '~' || n == '@' || n == '#' || n == '`' || n == '$' || n == '%' || n == '^' 
        || n == '&' || n == '*' || n == '(' || n == ')' || n == '-' || n == '_' || n == '+'
        || n == '|' || n == '[' || n == ']' || n == ':' || n == '<' || n == '>' || n == '?')
        total_symbol++;
    else
        total_consonant++;
}
Console.WriteLine("Total characters: " + texts.Length);
Console.WriteLine("Total vowels: " + total_vowel);
Console.WriteLine("Total spaces: " + total_space);
Console.WriteLine("Total symbols: " + total_space);
Console.WriteLine("Total consonants: " + total_consonant);