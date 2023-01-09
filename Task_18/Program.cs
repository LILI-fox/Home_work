using static Common.Helper;

// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Введите коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine());

if(k1-k2!=0)
{
double x = GetXCoord(k1, b1, k2, b2);

double y = GetYCoord(k1, b1, x);

Console.WriteLine($"Точка пересечения двух прямых: ({x};{y}).");
}
else
{
    Console.WriteLine("Прямые не пересекаются!Введите другие координаты!");
}
double GetXCoord(double k1, double b1, double k2, double b2)
{
    double x = -(b1-b2)/(k1-k2);
return x;
}

double GetYCoord(double k1, double b1, double x)
{
    double y = k1 * x + b1;
return y;
}