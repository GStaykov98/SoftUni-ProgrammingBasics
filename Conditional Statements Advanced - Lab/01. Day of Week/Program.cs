﻿int num = int.Parse(Console.ReadLine());

if (num >= 1 &&
    num <= 7)
{
	switch (num)
	{
		case 1:
            Console.WriteLine("Monday");
			break;
		case 2:
			Console.WriteLine("Tuesday");
			break;
		case 3:
			Console.WriteLine("Wednesday");
				break;
		case 4:
            Console.WriteLine("Thursday");
			break;
		case 5:
			Console.WriteLine("Friday");
			break;
		case 6:
			Console.WriteLine("Saturday");
			break;
		case 7:
            Console.WriteLine("Sunday");
			break;
    }
}
else
{
	Console.WriteLine("Error");
}