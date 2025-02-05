int n = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());
int pointsFromTournaments = 0;
int countOfWins = 0;

for (int i = 0; i < n; i++)
{
    string result = Console.ReadLine();

	if (result == "W")
	{
		points += 2000;
		pointsFromTournaments += 2000;
		countOfWins++;
	}
	else if (result == "F")
	{
		points += 1200;
		pointsFromTournaments += 1200;
	}
	else if (result == "SF")
	{
		points += 720;
		pointsFromTournaments += 720;
	}
}

double averagePoints = (double)pointsFromTournaments / n;
double winPercent = (double)countOfWins / n * 100;

Console.WriteLine("Final points: " + points);
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winPercent:f2}%");