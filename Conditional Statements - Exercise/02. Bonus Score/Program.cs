int a = int.Parse(Console.ReadLine());
double bonusPoints = 0;

if (a <= 100)
{
    bonusPoints += 5;
}
else if (a <= 1000)
{
    bonusPoints = a * 0.2;
}
else
{
    bonusPoints = a * 0.1;
}

if (a % 2 == 0)
{
    bonusPoints += 1;
}

if (a % 10 == 5)
{
    bonusPoints += 2;
}

Console.WriteLine(bonusPoints);
Console.WriteLine(a + bonusPoints);