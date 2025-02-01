string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

if (sales >= 0 &&
    sales <= 500)
{
	if (city == "Sofia")
	{
        Console.WriteLine($"{sales * 0.05:f2}");
    }
	else if (city == "Varna")
	{
        Console.WriteLine($"{sales * 0.045:f2}");
    }
	else if (city == "Plovdiv")
	{
        Console.WriteLine($"{sales * 0.055:f2}");
    }
	else
	{
        Console.WriteLine("error");
    }
}
else if (sales <= 1000)
{
    if (city == "Sofia")
    {
        Console.WriteLine($"{sales * 0.07:f2}");
    }
    else if (city == "Varna")
    {
        Console.WriteLine($"{sales * 0.075:f2}");
    }
    else if (city == "Plovdiv")
    {
        Console.WriteLine($"{sales * 0.08:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (sales <= 10000)
{
    if (city == "Sofia")
    {
        Console.WriteLine($"{sales * 0.08:f2}");
    }
    else if (city == "Varna")
    {
        Console.WriteLine($"{sales * 0.1:f2}");
    }
    else if (city == "Plovdiv")
    {
        Console.WriteLine($"{sales * 0.12:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (sales > 10000)
{
    if (city == "Sofia")
    {
        Console.WriteLine($"{sales * 0.12:f2}");
    }
    else if (city == "Varna")
    {
        Console.WriteLine($"{sales * 0.13:f2}");
    }
    else if (city == "Plovdiv")
    {
        Console.WriteLine($"{sales * 0.145:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}