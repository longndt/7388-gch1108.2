using System.Diagnostics;
using System.Text;

//StringBuiler: higher performance: faster speed
Stopwatch sw = new Stopwatch();
sw.Start();
StringBuilder text = new StringBuilder();
for (int i = 0; i < 200000; i++)
{
    text.Append(i);
    //Console.WriteLine(text);
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);  

//String: lower performance: slower speed
Stopwatch sw1 = new Stopwatch();
sw.Start();
string text1 = "";
for (int i = 0; i < 200000; i++)
{
    text1 += i;
    //Console.WriteLine(text1);
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);  

string s = "greenwich";
s = "vietnam " + s;
Console.WriteLine(s);   

StringBuilder sb = new StringBuilder();
sb.Append("greenwich"); //add content to the end of string builder
sb.Append(" vietnam");
Console.WriteLine(sb);


