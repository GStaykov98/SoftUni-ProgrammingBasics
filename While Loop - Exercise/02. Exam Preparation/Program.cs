int maxBadGradesAllowed = int.Parse(Console.ReadLine());
string input;
int totalGrades = 0;
int problemsSolved = 0;
string lastProblem = string.Empty;
int countOfBadGrades = 0;

while ((input = Console.ReadLine()) != "Enough")
{
    int currentGrade = int.Parse(Console.ReadLine());

    totalGrades += currentGrade;
    problemsSolved++;
    lastProblem = input;

    if (currentGrade <= 4)
    {
        countOfBadGrades++;

        if (countOfBadGrades == maxBadGradesAllowed)
        {
            Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");
            return;
        }
    }
}

double averageScore = (double)totalGrades / problemsSolved;
Console.WriteLine($"Average score: {averageScore:f2}");
Console.WriteLine($"Number of problems: {problemsSolved}");
Console.WriteLine($"Last problem: {lastProblem}");