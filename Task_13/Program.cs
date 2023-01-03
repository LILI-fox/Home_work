// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите необходимое количество элементов: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed || number <= 0)
{
    Console.WriteLine("Insert correct number!");
}

int[] array = new int[number];

Console.WriteLine("Введите первый элемент: ");
int N = int.Parse(Console.ReadLine());
array[0] = N;

Console.WriteLine("Введите следующие элементы: ");

int GetArray (int[] array)
{ 
    int i = 1;
    for (; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return i;
}
GetArray(array);

Console.Write("Полученный массив: ");
void PrintArray(int[] array)
{
    int i = 0;
    for (; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);

