int n = int.Parse(Console.ReadLine());

for (int i = 1111; i < 10000; i++)
{
    string numberAsString = i.ToString();
    bool isSpecial = true;

    for (int j = 0; j < numberAsString.Length; j++)
    {
        int currentDigit = int.Parse(numberAsString[j].ToString());

        if (currentDigit == 0 || n % currentDigit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}