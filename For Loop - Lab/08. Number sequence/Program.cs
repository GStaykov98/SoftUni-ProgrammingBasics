int n = int.Parse(Console.ReadLine());
int maxNum = int.MinValue;
int minNum = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < minNum)
    {
        minNum = num;
    }

    if (num > maxNum)
    {
        maxNum = num;
    }
}

Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");