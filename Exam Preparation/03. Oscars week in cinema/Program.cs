string movie = Console.ReadLine();
string roomType = Console.ReadLine();
int ticketsSold = int.Parse(Console.ReadLine());
double income = 0;

switch (movie)
{
    case "A Star Is Born":

        switch (roomType)
        {
            case "normal":
                income = ticketsSold * 7.5;
                break;
            case "luxury":
                income = ticketsSold * 10.5;
                break;
            case "ultra luxury":
                income = ticketsSold * 13.5;
                break;
        }

        break;
    case "Bohemian Rhapsody":

        switch (roomType)
        {
            case "normal":
                income = ticketsSold * 7.35;
                break;
            case "luxury":
                income = ticketsSold * 9.45;
                break;
            case "ultra luxury":
                income = ticketsSold * 12.75;
                break;
        }

        break;
    case "Green Book":

        switch (roomType)
        {
            case "normal":
                income = ticketsSold * 8.15;
                break;
            case "luxury":
                income = ticketsSold * 10.25;
                break;
            case "ultra luxury":
                income = ticketsSold * 13.25;
                break;
        }

        break;
    case "The Favourite":

        switch (roomType)
        {
            case "normal":
                income = ticketsSold * 8.75;
                break;
            case "luxury":
                income = ticketsSold * 11.55;
                break;
            case "ultra luxury":
                income = ticketsSold * 13.95;
                break;
        }

        break;
}

Console.WriteLine($"{movie} -> {income:f2} lv.");