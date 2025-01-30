const double puzzlePrice = 2.6;
const double dollPrice = 3;
const double tedyBearPrice = 4.1;
const double minionPrice = 8.2;
const double carPrice = 2;

double vacationPrice = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int dollCount = int.Parse(Console.ReadLine());
int tedyBearCount = int.Parse(Console.ReadLine());
int minionCount = int.Parse(Console.ReadLine());
int carCount = int.Parse(Console.ReadLine());
int toysCount = puzzleCount + dollCount + tedyBearCount + minionCount + carCount;

double puzzlesTotalPrice = puzzlePrice * puzzleCount;
double dollsTotalPrice = dollPrice * dollCount;
double tedyBearsTotalPrice = tedyBearPrice * tedyBearCount;
double minionsTotalPrice = minionPrice * minionCount;
double carsTotalPrice = carPrice * carCount;

double totalPrice = puzzlesTotalPrice + dollsTotalPrice + tedyBearsTotalPrice + minionsTotalPrice + carsTotalPrice;

if (toysCount >= 50)
{
    totalPrice -= totalPrice * 0.25;
}

totalPrice -= totalPrice * 0.1;

if (totalPrice >= vacationPrice)
{
    double moneyLeft = totalPrice - vacationPrice;
    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
}
else
{
    double moneyNeeded = vacationPrice - totalPrice;
    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
}