double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double interestPercent = double.Parse(Console.ReadLine());

double sum = deposit + months * ((deposit * (interestPercent / 100)) / 12);

Console.WriteLine(sum);