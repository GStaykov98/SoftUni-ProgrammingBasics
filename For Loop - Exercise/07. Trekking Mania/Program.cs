int n = int.Parse(Console.ReadLine());
int countOfPeople = 0;
int musalaClimbers = 0;
int montBlancClimbers = 0;
int kilimanjaroClimbers = 0;
int k2Climbers = 0;
int everestClimbers = 0;

for (int i = 0; i < n; i++)
{
    int people = int.Parse(Console.ReadLine());
    countOfPeople += people;

    if (people <= 5)
    {
        musalaClimbers += people;
    }
    else if (people <= 12)
    {
        montBlancClimbers += people;
    }
    else if (people <= 25)
    {
        kilimanjaroClimbers += people;
    }
    else if (people <= 40)
    {
        k2Climbers += people;
    }
    else
    {
        everestClimbers += people;
    }
}

Console.WriteLine($"{(double)musalaClimbers / countOfPeople * 100.0:f2}%");
Console.WriteLine($"{(double)montBlancClimbers / countOfPeople * 100.0:f2}%");
Console.WriteLine($"{(double)kilimanjaroClimbers / countOfPeople * 100.0:f2}%");
Console.WriteLine($"{(double)k2Climbers / countOfPeople * 100.0:f2}%");
Console.WriteLine($"{(double)everestClimbers / countOfPeople * 100.0:f2}%");