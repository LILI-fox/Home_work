using static Common.Helper;

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начало интервала (число M): ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите конец интервала (число N): ");
int N = int.Parse(Console.ReadLine());

GetSunNumsInInterval(0, M, N);

void GetSunNumsInInterval(int sum, int M, int N)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке [M;N] равна {sum}.");
        return;
    }
    sum = sum + (M++);
    GetSunNumsInInterval(sum, M, N);
}

