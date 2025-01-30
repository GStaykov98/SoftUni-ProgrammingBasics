int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 15;

if (minutes >= 60)
{
    minutes = minutes % 60;
    hours += 1;
}

if (hours >= 24)
{
    hours = hours % 24;
}

Console.WriteLine($"{hours}:{minutes:d2}");