
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// 1 вариант записи

double InputInt()
{
    Console.Write("Введите число: ");
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if(isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введите корректное число!");
        return -1;
    }
}

double xa = InputInt();
double ya = InputInt();
double za = InputInt();
double xb = InputInt();
double yb = InputInt();
double zb = InputInt();

// 2 вариант записи 

/*
Console.WriteLine("Введите 1 координату точки А");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xa);

if (!isParsedXA)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
} 

Console.WriteLine("Введите 2 координату точки А");
bool isParsedYA = int.TryParse(Console.ReadLine(), out int ya);

if (!isParsedYA)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

Console.WriteLine("Введите 3 координату точки А");
bool isParsedZA = int.TryParse(Console.ReadLine(), out int za);

if (!isParsedZA)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
} 

Console.WriteLine("Введите 1 координату точки В");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xb);

if (!isParsedXB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

Console.WriteLine("Введите 2 координату точки В");
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yb);

if (!isParsedYB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

Console.WriteLine("Введите 3 координату точки В");
bool isParsedZB= int.TryParse(Console.ReadLine(), out int zb);

if (!isParsedZB)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
} 
*/

double GetDistanceBetweenTwoPoints(double xa, double ya, double za, double xb, double yb, double zb)

{
    double ab = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return ab;
}
double res = GetDistanceBetweenTwoPoints(xa, ya, za, xb, yb, zb);

Console.WriteLine(res);

