using System.ComponentModel.Design;

Console.WriteLine("Enter lower range");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter upper range");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of attempts");
var n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int pcNum = rand.Next(a, b);


var attemptCounter = 0;
while (attemptCounter <= n)
{
    attemptCounter++;
    Console.WriteLine("Enter a guess");
    var guess = Convert.ToInt32(Console.ReadLine());
    
    if (guess == pcNum)
    {
        Console.WriteLine("You've won!");
        break;
    }
    else
    {
        if (guess > b || guess < a)
        {
            Console.WriteLine("You entered number not in range of possible answers LOL, try again, this did not count as an attempt");
            attemptCounter--;
        }
        else if (attemptCounter == n)
        {
            Console.WriteLine("You've lost!");
            break;
        }
        else
        {
            Console.WriteLine(guess > pcNum ? "The number is less than your guess" : "The number is greater than your guess");

        }
    }
}