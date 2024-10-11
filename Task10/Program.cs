int[] arr = {2, 3, 4, 5, 6, 7, 8, 10, 11};
int oddCounter = 0;
int evenCounter = 0;
for (int i = 0; i<arr.Length; i++)
{
    if (arr[i] % 2 == 0) evenCounter++;
    else oddCounter++;
}
Console.WriteLine($"Amount of even numbers - {evenCounter}, amount of odd numbers - {oddCounter}");