// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int count = number.ToString().Length;

int array(int arg1, int arg2)
{
    int result = 0;
    if(arg2>=3)
        {
        int numberC = 1;
        for (int i = arg2; i > 3; i--)
            {
                numberC = numberC * 10;
            }
        result = (arg1 / numberC) % 10;
        }
    return result;
}

Console.WriteLine($"Третья цифра числа {number} равна {array(number, count)}"); 

if (count <= 2)
{
    Console.WriteLine($"В числе {number} нет третьей цифры. Цифр в числе: {count}. Введите трехзначное число!");
}