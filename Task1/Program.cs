var a = Convert.ToInt32(Console.ReadLine());
var b  = Convert.ToInt32(Console.ReadLine());
var temp = a;
a = b;
b = temp;
Console.WriteLine(a);
Console.WriteLine(b);