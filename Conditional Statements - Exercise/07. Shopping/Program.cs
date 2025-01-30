double budget = double.Parse(Console.ReadLine());
int gpuCount = int.Parse(Console.ReadLine());
int cpuCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

double gpuPrice = gpuCount * 250.0;
double cpuPrice = cpuCount * (gpuPrice * 0.35);
double ramPrice = ramCount * (gpuPrice * 0.1);

double totalPrice = gpuPrice + cpuPrice + ramPrice;

if (gpuCount > cpuCount)
{
    totalPrice -= totalPrice * 0.15;
}

if (budget >= totalPrice)
{
    double moneyLeft = budget - totalPrice;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    double moneyNeeded = totalPrice - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
}