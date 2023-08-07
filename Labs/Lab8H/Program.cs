using System.Text;

/* StringBuilder methods:
 * Append()
 * Length
 * Clear()
 * Replace()
 * ToString()
 */

StringBuilder sb = new StringBuilder();
sb.Append("hanoi");
sb.Append("\nhcm city");
sb.Append("\nda nang");
Console.WriteLine(sb);
Console.WriteLine("Length before remove: " + sb.Length);
sb.Clear();
Console.WriteLine("Length after remove: " + sb.Length);
sb.Append("hanoi");
sb.Append("\nhcm city");
sb.Append("\nda nang");
sb.Replace("hanoi", "Ha Noi");
Console.WriteLine(sb);  
String s = sb.ToString();
Console.WriteLine(s);