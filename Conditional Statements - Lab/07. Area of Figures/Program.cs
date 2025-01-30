string shape = Console.ReadLine();

switch (shape)
{
	case "square":
		double a = double.Parse(Console.ReadLine());
		double area = a * a;
        Console.WriteLine($"{area:f3}");
        break;
	case "rectangle":
		a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		area = a * b;
        Console.WriteLine($"{area:f3}");
        break;
	case "circle":
		a = double.Parse(Console.ReadLine());
		area = Math.PI * Math.Pow(a, 2);
        Console.WriteLine($"{area:f3}");
        break;
	case "triangle":
		a = double.Parse(Console.ReadLine());
		b = double.Parse(Console.ReadLine());
		area = (a * b) / 2;
        Console.WriteLine($"{area:f3}");
        break;
}