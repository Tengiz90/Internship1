double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double D = b * b - 4 * a * c;


if (D > 0)
{
    double X1 = (-b - Math.Sqrt(D)) / (2 * a);
    double X2 = (-b + Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("X1 = " + X1);
    Console.WriteLine("X2 = " + X2);
}
else if (D == 0)
{
    double X = -b / (2 * a);
    Console.WriteLine("There is one real solution: X = " + X);
}
else
{
    Console.WriteLine("There are no real solutions.");
}