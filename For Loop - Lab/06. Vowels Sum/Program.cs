string input = Console.ReadLine();
int count = 0;

for (int i = 0; i < input.Length; i++)
{
	if (input[i] == 'a')
	{
		count += 1;
	}
	else if (input[i] == 'e')
	{
		count += 2;
	}
    else if (input[i] == 'i')
    {
        count += 3;
    }
    else if (input[i] == 'o')
    {
        count += 4;
    }
    else if (input[i] == 'u')
    {
        count += 5;
    }
}

Console.WriteLine(count);