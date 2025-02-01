string fruit = Console.ReadLine();
string day = Console.ReadLine();
double count = double.Parse(Console.ReadLine());

string typeOfDay = null;

if (day == "Monday"||
	day == "Tuesday"||
	day == "Wednesday"||
	day == "Thursday"||
	day == "Friday")
{
	typeOfDay = "Weekday";
}
else if (day == "Saturday"||
		 day == "Sunday")
{
	typeOfDay = "Weekend";
}

switch (fruit)
{
	case "banana":
		if (typeOfDay == "Weekday")
		{
			Console.WriteLine($"{2.5 * count:f2}");
		}
		else if (typeOfDay == "Weekend")
		{
            Console.WriteLine($"{2.7 * count:f2}");
        }
		else
		{
            Console.WriteLine("error");
        }
		break;
	case "apple":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{1.2 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{1.25 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "orange":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{0.85 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{0.9 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "grapefruit":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{1.45 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{1.6 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "kiwi":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{2.7 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{3 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "pineapple":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{5.5 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{5.6 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "grapes":
        if (typeOfDay == "Weekday")
        {
            Console.WriteLine($"{3.85 * count:f2}");
        }
        else if (typeOfDay == "Weekend")
        {
            Console.WriteLine($"{4.2 * count:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}