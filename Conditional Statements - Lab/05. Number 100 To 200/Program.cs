int a = int.Parse(Console.ReadLine());
const int minNumber = 100;
const int maxNumber = 200;

if (a < minNumber)
{
    Console.WriteLine("Less than 100");
}
else if (a >= minNumber && a <= maxNumber)
{
    Console.WriteLine("Between 100 and 200");
}
else if (a > maxNumber)
{
    Console.WriteLine("Greater than 200");
}