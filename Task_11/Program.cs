// Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
// и метод, который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Insert first number: ");

bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);

if(!isParsed1|| number1==0)
{
    Console.WriteLine("Insert correct number!");
}
Console.WriteLine("Insert second number: ");

bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);

if(!isParsed2|| number2==0)
{
    Console.WriteLine("Insert correct number!");
}

int res = GetExponentiation (number1, number2);
Console.Write("Полученный результат: ");
Console.WriteLine(res);

int GetExponentiation(int number1, int number2)
{
    int i = 0;
    int result = 1;
    for (; i < number2; i++)
    {
        result = result * number1;
    }
    return result;
}
