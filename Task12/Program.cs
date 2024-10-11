class Program
{
    public static bool IsSimple(uint num)
    {
        bool isSimple = true;

        if (num == 1)
            isSimple = false;

        for (uint i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                isSimple = false; break;
            }
        }
        return isSimple;

    }
    public static void Main()
    {
        uint[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        for (uint i = 0; i < arr.Length; i++)
        {
            if (IsSimple(arr[i])) Console.WriteLine(arr[i]);
        }
    }
}