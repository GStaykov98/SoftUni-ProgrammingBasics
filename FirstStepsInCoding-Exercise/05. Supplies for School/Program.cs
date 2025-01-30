const double penPrice = 5.8;
const double markerPrice = 7.2;
const double sprayPrice = 1.2;

int penNum = int.Parse(Console.ReadLine());
int markersNum = int.Parse(Console.ReadLine());
int sprayNum = int.Parse(Console.ReadLine());
double discountPercent = double.Parse(Console.ReadLine());

double sum = (penNum * penPrice) + (markersNum * markerPrice) + (sprayNum * sprayPrice);
double totalSumWithDiscount = sum - (sum * (discountPercent / 100));

Console.WriteLine(totalSumWithDiscount);