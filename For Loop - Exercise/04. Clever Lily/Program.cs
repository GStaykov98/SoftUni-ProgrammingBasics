int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());
int toyCount = 0;
int moneyGift = 10;
double totalMoney = 0;

for (int i = 1; i <= age; i++)
{
	if (i % 2 == 0)
	{
		totalMoney += moneyGift - 1;
		moneyGift += 10;
	}
	else
	{
		toyCount++;
	}
}

int totalToyPrice = toyCount * toyPrice;
totalMoney += totalToyPrice;

if (totalMoney >= washingMachinePrice)
{
	double moneyLeft = totalMoney - washingMachinePrice;
    Console.WriteLine($"Yes! - {moneyLeft:f2}");
}
else
{
	double moneyNeeded = washingMachinePrice - totalMoney;
    Console.WriteLine($"No! - {moneyNeeded:f2}");
}