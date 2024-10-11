class Program
{
    public static bool IsEven(int num)
    {
        if (num % 2 == 0) return true;
        else return false;
    }
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 5, 6, 7, 8, 10, 11 };
        foreach(int num in arr)
            if (IsEven(num)) Console.WriteLine(num);
    }
}



