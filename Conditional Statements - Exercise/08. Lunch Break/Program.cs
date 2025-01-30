string movieName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());

double lunchTime = breakLength / 8.0;
double restTime = breakLength / 4.0;

double neededTime = lunchTime + restTime + episodeLength;

if (breakLength >= neededTime)
{
    double timeLeft = breakLength - neededTime;
    Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
}
else
{
    double timeNeeded = neededTime - breakLength;
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(timeNeeded)} more minutes.");
}