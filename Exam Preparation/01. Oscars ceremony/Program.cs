int rent = int.Parse(Console.ReadLine());

double statues = (double)rent * 0.7;
double catering = statues * 0.85;
double sound = catering / 2;

double totalExpenses = rent + statues + sound + catering;

Console.WriteLine($"{totalExpenses:f2}");