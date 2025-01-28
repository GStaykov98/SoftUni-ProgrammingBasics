string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());
int neededHours = projects * 3;

Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {projects} project/s.");