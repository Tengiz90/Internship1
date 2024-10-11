int[] numbers = { 4, -9, 50, 30, 2, 0, 7, -5, -6, -7, -9, -30 };
int max = numbers[0];

for (int i = 1; i< numbers.Length; i++)
{
    if (max < numbers[i]) max = numbers[i];
}

Console.WriteLine(max);