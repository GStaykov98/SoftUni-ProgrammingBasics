string input = Console.ReadLine();

if (input == "Monday"||
    input == "Tuesday"||
    input == "Wednesday"||
    input == "Thursday"||
    input == "Friday")
{
    Console.WriteLine("Working day");
}
else if (input == "Saturday"||
         input == "Sunday")
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Error");
}