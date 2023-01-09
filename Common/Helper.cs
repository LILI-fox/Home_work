namespace Common;

public static class Helper
{
    public static void PrintArray(int[] array)
                {
                    string message = string.Join(", ", array);
                    Console.WriteLine($"[{message}]");
                }
    public static int[] GenerateArray(int min, int max, int lenght)
                {
                    Random random = new Random();
                    int[] array = new int[lenght];
                    for (int i = 0; i < array.Length; i++)
                    {
                      array[i] = random.Next(min, max + 1);
                    }
                return array;
                }
    public static int InputNumber()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);
        if(isParsed)
        {
            return number;
        }
        else
        {
            throw new Exception("Введите корректное число!");
        }
    }
}
