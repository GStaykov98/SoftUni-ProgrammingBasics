int n = int.Parse(Console.ReadLine());
int count = 1;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (count > n)
        {
            break;
        }

        Console.Write(count + " ");
        count++;
    }
    Console.WriteLine();
}