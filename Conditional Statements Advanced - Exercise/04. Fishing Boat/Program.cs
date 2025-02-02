﻿int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int countOfFishers = int.Parse(Console.ReadLine());
double rent = 0.0;

if (season == "Spring")
{
    rent = 3000;
}
else if (season == "Summer" ||  season == "Autumn")
{
    rent = 4200;
}
else if (season == "Winter")
{
    rent = 2600;
}

if (countOfFishers <= 6)
{
    rent -= rent * 0.1;
}
else if (countOfFishers <= 11)
{
    rent -= rent * 0.15;
}
else if (countOfFishers >= 12)
{
    rent -= rent * 0.25;
}

if (countOfFishers % 2 == 0 && !(season == "Autumn"))
{
    rent -= rent * 0.05;
}

if (budget - rent >= 0)
{
    double moneyLeft = budget - rent;
    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
}
else
{
    double moneyNeeded = rent - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
}