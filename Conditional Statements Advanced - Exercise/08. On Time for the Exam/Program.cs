int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinutes = int.Parse(Console.ReadLine());

int examTimeInMinutes = examHour * 60 + examMinutes;
int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinutes;

if (examTimeInMinutes > arrivalTimeInMinutes)
{
    int minutesEarly = examTimeInMinutes - arrivalTimeInMinutes;

	if (minutesEarly > 30)
	{
        Console.WriteLine("Early");

		if (minutesEarly >= 60)
		{
			int hoursEarly = minutesEarly / 60;
			minutesEarly = minutesEarly % 60;

            Console.WriteLine($"{hoursEarly}:{minutesEarly:d2} hours before the start");
        }
		else
		{
            Console.WriteLine($"{minutesEarly} minutes before the start");
        }
    }
	else
	{
        Console.WriteLine("On time");
        Console.WriteLine($"{minutesEarly} minutes before the start");
    }
}
else if (examTimeInMinutes < arrivalTimeInMinutes)
{
    Console.WriteLine("Late");

    int minutesLate = arrivalTimeInMinutes - examTimeInMinutes;

    if (minutesLate >= 60)
    {
        int hoursLate = minutesLate / 60;
        minutesLate = minutesLate % 60;

        Console.WriteLine($"{hoursLate}:{minutesLate:d2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
}
else
{
    Console.WriteLine("On time");
}