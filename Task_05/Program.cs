// Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5; 782 -> 8; 918 -> 1

Console.Write("Введите целое трехзначное число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Вы ввели не целое число. Введите другое число!");
    return;
}
if (number < 0 | number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число. Введите другое число!");
}

    int FSnumber = number / 10;
    int secondNumber = FSnumber % 10;

    Console.WriteLine($"Вторая цифра числа {number} - {secondNumber}");
