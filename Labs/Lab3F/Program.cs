char A = 'A';
char Z = 'Z';
int total_vowel = 0, total_consonant = 0;

for (int i= (int)A; i<= (int)Z; i++)
{
    char c = (char)i;
    if (c == 'A' || c == 'E' || c == 'I' || c == 'U' || c == 'O') {
        Console.WriteLine(c + " : " + i + " - Vowel");
        total_vowel++;
    }
    else
    {
        Console.WriteLine(c + " : " + i + " - Consonant");
        total_consonant++;
    }
}
Console.WriteLine("Total vowel: " + total_vowel);
Console.WriteLine("Total consonant: " + total_consonant);


char a = 'a';
char z = 'z';

for (int i = (int)a; i <= (int)z; i++)
{
    char c = (char)i;
    if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o')
        Console.WriteLine(c + " : " + i + " - Vowel");
    else
        Console.WriteLine(c + " : " + i + " - Consonant");
}

