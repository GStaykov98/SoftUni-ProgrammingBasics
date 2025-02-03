string month = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double apartmentPrice = 0;
double studioPrice = 0;

if (month == "May" || month == "October")
{
    apartmentPrice = days * 65.0;
    studioPrice = days * 50.0;

    if (days > 14)
    {
        studioPrice -= studioPrice * 0.3;
        apartmentPrice -= apartmentPrice * 0.1;
    }
    else if (days > 7)
    {
        studioPrice -= studioPrice * 0.05;
    }
}
else if (month == "June" || month == "September")
{
    apartmentPrice = days * 68.7;
    studioPrice = days * 75.2;

    if (days > 14)
    {
        studioPrice -= studioPrice * 0.2;
        apartmentPrice -= apartmentPrice * 0.1;
    }
}
else if (month == "July" || month == "August")
{
    apartmentPrice = days * 77.0;
    studioPrice = days * 76.0;

    if (days > 14)
    {
        apartmentPrice -= apartmentPrice * 0.1;
    }
}

Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:f2} lv.");