int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int freeSpace = a * b * c;
string input;

while ((input = Console.ReadLine()) != "Done")
{
    int boxes = int.Parse(input);
    freeSpace -= boxes;

    if (freeSpace < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        return;
    }
}

Console.WriteLine($"{freeSpace} Cubic meters left.");