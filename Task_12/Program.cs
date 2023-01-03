// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12


Console.Write("Insert number: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed || number == 0)
{
 Console.WriteLine("Insert correct number!");
}

int GetNumberOfDigits(int number)
{
     int count = 0;
     for (; number != 0; count++)
     {
         number = number / 10;
     }
     return count;
}

int count = GetNumberOfDigits(number);

int GetSumOfDigits(int number)
{
    int count = GetNumberOfDigits(number);
    int sum=0;
    int lastNumber = 0;
    for (int i = 0; i < count; i++)
    {
        lastNumber = number%10;
        sum = sum + lastNumber;
        number = number/10;
    }
    return sum;
}

int result = GetSumOfDigits(number);

Console.WriteLine($"Полученная сумма: {result}");



