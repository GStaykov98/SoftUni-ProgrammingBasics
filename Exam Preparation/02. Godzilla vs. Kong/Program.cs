double budget = double.Parse(Console.ReadLine());
int actorsCount = int.Parse(Console.ReadLine());
double dressPricePerActor = double.Parse(Console.ReadLine());
double decorPrice = budget * 0.1;

double dressTotalPrice = dressPricePerActor * actorsCount;

if (actorsCount > 150)
{
    dressTotalPrice -= dressTotalPrice * 0.1;
}

double totalPriceOfMovie = dressTotalPrice + decorPrice;

if (budget >= totalPriceOfMovie)
{
    double moneyLeft = budget - totalPriceOfMovie;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
}
else
{
    double moneyNeeded = totalPriceOfMovie - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
}