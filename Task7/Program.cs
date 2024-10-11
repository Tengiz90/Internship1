uint num = 34;
bool isSimple = true;

if (num == 1)
    isSimple = false;

for (uint i = 2;  i < num; i++)
{
    if (num % i == 0)
    {
        isSimple = false; break;
    }
}

Console.WriteLine(isSimple ? "Is simple" : "Is not simple");