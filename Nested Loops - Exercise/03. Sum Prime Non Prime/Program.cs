string input;
int primeNumbersSum = 0;
int nonPrimeNumbersSum = 0;

while ((input = Console.ReadLine()) != "stop")
{
    int num = int.Parse(input);

	if (num < 0)
	{
        Console.WriteLine("Number is negative.");
        continue;
    }

    int divisorsCount = 0;
    bool isPrime = true;

    for (int i = 1; i <= num; i++)
    {
        if (num == 1)
        {
            isPrime = false;
            break;
        }

        if (num % i == 0)
        {
            divisorsCount++;

            if (divisorsCount > 2)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        primeNumbersSum += num;
    }
    else
    {
        nonPrimeNumbersSum += num;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");