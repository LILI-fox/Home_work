// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GenerateArray(100, 999, 10);

PrintArray(array);

int[] resultArray = GetPositiveNumbers(array);

PrintArray(resultArray);

int[] GenerateArray(int min, int max, int lenght)
{
    Random random = new Random();
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] GetPositiveNumbers(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}