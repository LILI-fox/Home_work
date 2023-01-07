// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GenerateArray(100, 999, 10);

PrintArray(array);

int[] resultArray = GetEvenNumbers(array);

PrintArray(resultArray);

int result = GetCountEvenNumbers(resultArray);

Console.WriteLine($"Количество четных чисел в массиве равно {result}.");

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

int[] GetEvenNumbers(int[] array)
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

int GetCountEvenNumbers(int[] resultArray)
{
    int count = 0;
    for (int i = 0; i < resultArray.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
        count = count + 1;
        }
    }
    return count;
}
