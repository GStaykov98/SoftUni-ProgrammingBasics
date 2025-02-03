int n = int.Parse(Console.ReadLine());
int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n * 2; i++)
{
	int number = int.Parse(Console.ReadLine());

	if (i >= n)
	{
		rightSum += number;
	}
	else
	{
		leftSum += number;
	}
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}