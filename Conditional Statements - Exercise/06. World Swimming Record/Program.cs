double record = double.Parse(Console.ReadLine());
double length = double.Parse(Console.ReadLine());
double secondPerMeter = double.Parse(Console.ReadLine());

double swimmingTime = length * secondPerMeter;
double delay = Math.Floor(length / 15) * 12.5;

swimmingTime += delay;

if (swimmingTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimmingTime:f2} seconds.");
}
else
{
    double secondsLeft = swimmingTime - record;
    Console.WriteLine($"No, he failed! He was {secondsLeft:f2} seconds slower.");
}