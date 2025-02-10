int moviesCount = int.Parse(Console.ReadLine());
string highestRatingMovie = string.Empty;
double highestRating = double.MinValue;
string lowestRatingMovie = string.Empty;
double lowestRating = double.MaxValue;
double totalRating = 0;


for (int i = 0; i < moviesCount; i++)
{
    string currentMovie = Console.ReadLine();
    double currentRating = double.Parse(Console.ReadLine());
    totalRating += currentRating;

    if (currentRating > highestRating)
    {
        highestRating = currentRating;
        highestRatingMovie = currentMovie;
    }

    if (currentRating < lowestRating)
    {
        lowestRating = currentRating;
        lowestRatingMovie = currentMovie;
    }
}

Console.WriteLine($"{highestRatingMovie} is with highest rating: {highestRating:f1}");
Console.WriteLine($"{lowestRatingMovie} is with lowest rating: {lowestRating:f1}");
Console.WriteLine($"Average rating: {totalRating / moviesCount:f1}");