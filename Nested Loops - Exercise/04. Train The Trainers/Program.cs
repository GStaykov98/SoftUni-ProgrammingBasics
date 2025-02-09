int n = int.Parse(Console.ReadLine());
string input;
double totalGrades = 0;
int countOfAssessments = 0;

while ((input = Console.ReadLine()) != "Finish")
{
    string currentAssessment = input;
	double totalGradesForAssessment = 0;
	countOfAssessments++;

	for (int i = 0; i < n; i++)
	{
		double currentGrade = double.Parse(Console.ReadLine());
        totalGradesForAssessment += currentGrade;
	}

	double averageGrade = totalGradesForAssessment / n;
	totalGrades += averageGrade;

	Console.WriteLine($"{currentAssessment} - {averageGrade:f2}.");
}

double totalAverageGrade = totalGrades / countOfAssessments;

Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");