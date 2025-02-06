string searchedBook = Console.ReadLine();
string input;
int count = 0;

while ((input = Console.ReadLine()) != "No More Books")
{
	if (input != searchedBook)
	{
		count++;
	}
	else
	{
        Console.WriteLine($"You checked {count} books and found it.");
		return;
    }
}

Console.WriteLine("The book you search is not here!");
Console.WriteLine($"You checked {count} books.");