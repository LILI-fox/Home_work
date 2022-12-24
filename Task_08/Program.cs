//Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. 
// Задание должно быть выполнено в методе.
// В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет; 12821 -> да; 23432 -> да

bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}

int [] array = new int [5];

int [] result = CheckPalindrom(array);

int [] CheckPalindrom(int[] array)
{
    int reversePosition = array.Length-1;
    int[]newArr = new int[array.Length];
    for (int i = 0; i < array.Length-1; i++)
    {
        newArr[i] = array [reversePosition];
        reversePosition = reversePosition-1;
    }
    return newArr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

PrintArray(result);
/*
int Number = int.Parse(Console.ReadLine());

int CheckPalindrom(int number)
{
    int number0 = number/10000;
    int number1 = number/1000;
    int number3 = number%100;
    int number4 = number%10;
    if(number0==number4 & number1==number3)
    
}
*/
