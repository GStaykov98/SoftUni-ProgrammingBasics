string input;
int maxNum = int.MinValue;

while ((input = Console.ReadLine()) != "Stop")
{
    int num = int.Parse(input);

	if (num > maxNum)
	{
		maxNum = num;
	}
}

Console.WriteLine(maxNum);