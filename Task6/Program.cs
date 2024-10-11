double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(((a + b > c) && (a + c > b) && (b + c > a)) ? "Valid triangle" : "Invalid triangle");