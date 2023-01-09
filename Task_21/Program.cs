using static Common.Helper;

//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
uint m = uint.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
uint n = uint.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для неотрицательных чисел равна: A({m},{n}) = {FunAckermann(m, n)}.");

uint FunAckermann(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m != 0 && n == 0)
    {
        return FunAckermann(m - 1, 1);
    }
   
    if (m > 0 && n > 0) 
    {
        return FunAckermann(m - 1, FunAckermann(m, n - 1));
    }
    return FunAckermann(m, n);
}

