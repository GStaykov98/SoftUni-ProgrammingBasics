int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string review = Console.ReadLine();
double price = 0;

switch (roomType)
{
    case "room for one person":
        price = (days - 1) * 18.0;
        break;
    case "apartment":
        price = (days - 1) * 25.0;

        if (days < 10)
        {
            price -= price * 0.3;
        }
        else if (days <= 15)
        {
            price -= price * 0.35;
        }
        else
        {
            price -= price * 0.5;
        }
        break;
    case "president apartment":
        price = (days - 1) * 35.0;

        if (days < 10)
        {
            price -= price * 0.1;
        }
        else if (days <= 15)
        {
            price -= price * 0.15;
        }
        else
        {
            price -= price * 0.2;
        }
        break;
}

if (review == "positive")
{
    price += price * 0.25;
}
else
{
    price -= price * 0.1;
}

Console.WriteLine($"{price:f2}");