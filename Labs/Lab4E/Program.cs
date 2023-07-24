int[] n = { 12, 23, 34, 45, 56 };
String s = String.Join(" - ", n);
Console.WriteLine(s);
String[] s1 = { "Hanoi", "is", "the", "capital", "of", "Vietnam" };
String s2 = String.Join(" ", s1);
Console.WriteLine(s2);

String s3 = "G r e e n w i c h  V i e t n a m";
String[] s4 = s3.Split();
String s5 = String.Join(" ",s4);
Console.WriteLine(s5);
/* for (int i = s4.Length - 1; i >= 0; i--)
    Console.Write(s4[i]);
*/