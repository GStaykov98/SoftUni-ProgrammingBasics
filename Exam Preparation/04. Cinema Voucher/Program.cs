int budget = int.Parse(Console.ReadLine());
string input;
int movieTickets = 0;
int productsBought = 0;

while ((input = Console.ReadLine()) != "End")
{
	if (input.Length > 8)
	{
		int price = (int)input[0] + input[1];
		budget -= price;

		if (budget < 0)
		{
			break;
		}

		movieTickets++;
	}
	else
	{
		int price = (int)input[0];
		budget -= price;

        if (budget < 0)
        {
            break;
        }

        productsBought++;
	}
}

Console.WriteLine(movieTickets);
Console.WriteLine(productsBought);