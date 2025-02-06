string input = Console.ReadLine();
int goal = 10000;
int totalSteps = 0;
bool wentHome = false;

while (totalSteps < goal)
{
	int currentSteps = 0;
	if (input == "Going home")
	{
		wentHome = true;
		currentSteps = int.Parse(Console.ReadLine());
	}
	else
	{
        currentSteps = int.Parse(input);
    }

	totalSteps += currentSteps;

	if (wentHome)
	{
		if (totalSteps < goal)
		{
			int stepsNeeded = goal - totalSteps;
            Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
			return;
        }
		else
		{
			break;
        }
	}

	input = Console.ReadLine();
}

int stepsOver = totalSteps - goal;
Console.WriteLine("Goal reached! Good job!");
Console.WriteLine($"{stepsOver} steps over the goal!");