// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] array = GenerateArray(-10, 10, 10);

PrintArray(array);

int result = GetSumOddIndexNumbers(array);

Console.WriteLine($"Сумма элементов на нечетных индексах равна {result}.");

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

int GetSumOddIndexNumbers(int[]array)
{
    int [] newArray = new int[array.Length];
    int sum =0;
    for(int i=0; i< array.Length; i++)
    {
        if(i%2!=0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
