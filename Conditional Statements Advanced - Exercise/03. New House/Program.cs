string typeOfFLower = Console.ReadLine();
int countOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price = 0;

switch (typeOfFLower)
{
	case "Roses":
		price = countOfFlowers * 5.0;

		if (countOfFlowers > 80)
		{
			price -= price * 0.1;
		}
		break;
	case "Dahlias":
        price = countOfFlowers * 3.8;

        if (countOfFlowers > 90)
        {
            price -= price * 0.15;
        }
        break;
	case "Tulips":
        price = countOfFlowers * 2.8;

        if (countOfFlowers > 80)
        {
            price -= price * 0.15;
        }
        break;
    case "Narcissus":
        price = countOfFlowers * 3.0;

        if (countOfFlowers < 120)
        {
            price += price * 0.15;
        }
        break;
    case "Gladiolus":
        price = countOfFlowers * 2.5;

        if (countOfFlowers < 80)
        {
            price += price * 0.2;
        }
        break;
}

if (budget - price >= 0)
{
    double moneyLeft = budget - price;
    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFLower} and {moneyLeft} leva left.");
}
else
{
    double moneyNeeded = price - budget;
    Console.WriteLine($"Not enough money, you need {moneyNeeded} leva more.");
}