string student = Console.ReadLine();
int grade = 0;
double totalGrades = 0;
int failCount = 0;

while (grade < 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

    totalGrades += currentGrade;

    if (currentGrade < 4)
    {
        failCount++;

        if (failCount > 1)
        {
            Console.WriteLine($"{student} has been excluded at {grade} grade");
            return;
        }
    }

    grade++;
}

Console.WriteLine($"{student} graduated. Average grade: {totalGrades / 12:F2}");