string input;

while ((input = Console.ReadLine()) != "End")
{
    string destination = input;
    double budget = double.Parse(Console.ReadLine());
    double moneySaved = 0;

    while (budget > moneySaved)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        moneySaved += currentMoney;
    }

    Console.WriteLine($"Going to {destination}!");
}