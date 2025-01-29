int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double occupationPercent = double.Parse(Console.ReadLine());

int fishTankArea = length * width * height;
double areaInLitres = fishTankArea / 1000.0;
double neededLitres = areaInLitres - (areaInLitres * (occupationPercent / 100));

Console.WriteLine(neededLitres);