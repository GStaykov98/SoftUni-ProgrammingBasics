double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = string.Empty;
string typeOfBreak = string.Empty;
double moneySpent = 0;

if (budget <= 100)
{
	destination = "Bulgaria";

	if (season == "summer")
	{
		moneySpent = budget * 0.3;
		typeOfBreak = "Camp";
	}
	else if (season == "winter")
	{
		moneySpent = budget * 0.7;
		typeOfBreak = "Hotel";
	}
}
else if (budget <= 1000)
{
    destination = "Balkans";

    if (season == "summer")
    {
        moneySpent = budget * 0.4;
        typeOfBreak = "Camp";
    }
    else if (season == "winter")
    {
        moneySpent = budget * 0.8;
        typeOfBreak = "Hotel";
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    moneySpent = budget * 0.9;
    typeOfBreak = "Hotel";
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfBreak} - {moneySpent:f2}");