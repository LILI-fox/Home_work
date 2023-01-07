// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
// Не использовать готовые методы Min и Max
// [3 7 22 2 78] -> 76

int[] array = GenerateArray(-10, 10, 5);

PrintArray(array);

int min = GetMinElement(array);
Console.WriteLine($"Минимальный элемент в массиве {min}.");

int max = GetMaxElement(array);
Console.WriteLine($"Максимальный элемент в массиве {max}.");

int difference = GetDifferenceBetweenMaxMinElements(min, max);
Console.WriteLine($"Разница между {max} и {min} равна {difference}.");

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

int GetMinElement(int[] array)
{
    int[] newArray = new int[array.Length];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
}

int GetMaxElement(int[] array)
{
    int[] newArray = new int[array.Length];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i]>= max)
        {
            max = array[i];
        }
    }
    return max;
}

int GetDifferenceBetweenMaxMinElements(int min, int max)
{
    int difference = max - min;
    return difference;
}
