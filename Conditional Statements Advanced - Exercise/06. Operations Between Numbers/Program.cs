﻿int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
double result = 0;

switch (operation)
{
    case '+':
        result = n1 + n2;

        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} - {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} - {n2} = {result} - odd");
        }
        break;
    case '-':
        result = n1 - n2;

        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} - {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} - {n2} = {result} - odd");
        }
        break;
    case '*':
        result = n1 * n2;

        if (result % 2 == 0)
        {
            Console.WriteLine($"{n1} - {n2} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{n1} - {n2} = {result} - odd");
        }
        break;
    case '/':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
            break;
        }

        result = (n1 * 1.0) / n2;
        Console.WriteLine($"{n1} / {n2} = {result:f2}");
        break;
    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
            break;
        }

        result = n1 % n2;
        Console.WriteLine($"{n1} % {n2} = {result}");
        break;
}