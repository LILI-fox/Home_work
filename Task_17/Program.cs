using static Common.Helper;

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, -223-> 3

Console.WriteLine("Введите количество чисел: ");

int number = int.Parse(Console.ReadLine());

int[] array = GenerateArray(-1000, 1000, number);

PrintArray(array);

int result = GetPositiveNum(array);

Console.WriteLine($"Количество положительных чисел равно {result}.");

int GetPositiveNum(int[] array)
{
    int[] newArr = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}