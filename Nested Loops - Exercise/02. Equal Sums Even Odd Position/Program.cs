int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    string currentNum = i.ToString();
    int evenSum = 0;
    int oddSum = 0;

    for (int j = 0; j < currentNum.Length; j++)
    {
        int currentDigit = int.Parse(currentNum[j].ToString());

        if (j % 2 == 0)
        {
            evenSum += currentDigit;
        }
        else
        {
            oddSum += currentDigit;
        }
    }

    if (evenSum == oddSum)
    {
        Console.Write(i + " ");
    }
}