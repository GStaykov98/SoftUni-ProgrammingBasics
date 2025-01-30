int earlyPrice = int.Parse(Console.ReadLine());

double shoesPrice = earlyPrice * 0.6;
double clothesPrice = shoesPrice * 0.8;
double ballPrice = clothesPrice / 4.0;
double accesoryPrice = ballPrice / 5.0;

double totalPrice = shoesPrice + clothesPrice + ballPrice + accesoryPrice + earlyPrice;

Console.WriteLine(totalPrice);