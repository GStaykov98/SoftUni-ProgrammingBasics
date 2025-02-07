int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int pieces = a * b;
string input;

while ((input = Console.ReadLine()) != "STOP")
{
    int piecesToTake = int.Parse(input);

    pieces -= piecesToTake;

    if (pieces < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
        return;
    }
}

Console.WriteLine($"{pieces} pieces are left.");