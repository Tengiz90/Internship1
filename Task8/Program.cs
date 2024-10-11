var n = Convert.ToInt32(Console.ReadLine());
var sum = 0;

for (int i = 1; i < n; i++)
    if (n % i == 0)
        sum += i;

if (sum == n) Console.WriteLine("Is perfect number");
else Console.WriteLine("Is not perfect number");