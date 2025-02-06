double vacationPrice = double.Parse(Console.ReadLine());
double money = double.Parse(Console.ReadLine());
int countOfDaysSpending = 0;
int days = 0;

while (money < vacationPrice)
{
    days++;
    string operation = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());

    if (operation == "spend")
    {
        money -= sum;

        if (money < 0)
        {
            money = 0;
        }

        countOfDaysSpending++;

        if (countOfDaysSpending == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
            return;
        }
    }
    else if (operation == "save")
    {
        money += sum;
        countOfDaysSpending = 0;
    }
}

Console.WriteLine($"You saved the money for {days} days.");