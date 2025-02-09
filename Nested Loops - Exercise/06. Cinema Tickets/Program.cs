string input;
int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while ((input = Console.ReadLine()) != "Finish")
{
    string movie = input;
    int seats = int.Parse(Console.ReadLine());
    int ticketsSold = 0;
    string command;

    while ((command = Console.ReadLine()) != "End")
    {
        switch (command)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidTickets++;
                break;
        }

        ticketsSold++;
        totalTickets++;

        if (ticketsSold == seats)
        {
            break;
        }
    }

    double percentFull = (double)ticketsSold / seats * 100;

    Console.WriteLine($"{movie} - {percentFull:f2}% full.");
}

double studentTicketsPercent = (double)studentTickets / totalTickets * 100;
double standardTicketsPercent = (double)standardTickets / totalTickets * 100;
double kidTicketsPercent = (double)kidTickets / totalTickets * 100;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");