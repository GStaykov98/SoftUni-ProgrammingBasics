string actor = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string evaluative = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());

    academyPoints += evaluative.Length * points / 2;

    if (academyPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyPoints:f1}!");
        return;
    }
}

double pointsNeeded = 1250.50 - academyPoints;
Console.WriteLine($"Sorry, {actor} you need {pointsNeeded:f1} more!");