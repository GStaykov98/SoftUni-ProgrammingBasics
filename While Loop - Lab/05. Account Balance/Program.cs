﻿string input;
double sum = 0;

while ((input = Console.ReadLine()) != "NoMoreMoney")
{
    double payment = double.Parse(input);

	if (payment < 0)
	{
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {payment:f2}");
    sum += payment;
}

Console.WriteLine($"Total: {sum:f2}");