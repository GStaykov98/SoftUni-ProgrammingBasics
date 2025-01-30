const double chickenMenu = 10.35;
const double fishMenu = 12.40;
const double veganMenu = 8.15;
const double deliveryFee = 2.5;

int chickenMenuCount = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int veganMenuCount = int.Parse(Console.ReadLine());

double chickenMenuPrice = chickenMenu * chickenMenuCount;
double fishMenuPrice = fishMenu * fishMenuCount;
double veganMenuPrice = veganMenu * veganMenuCount;

double totalPrice = chickenMenuPrice + fishMenuPrice + veganMenuPrice;

totalPrice += totalPrice * 0.2;
totalPrice += deliveryFee;

Console.WriteLine(totalPrice);