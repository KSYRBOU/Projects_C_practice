// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumStringArray(int[,] array)
{
    int sumMin = int.MaxValue;
    int indexMin = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumTemp = sumTemp + array[i, j];
        }
        if (sumTemp < sumMin)
        {
            sumMin = sumTemp;
            indexMin = i+1;
        }
    }
    Console.WriteLine($"Минимальная сумма строки = {sumMin}");
    Console.WriteLine($"Номер строки с минимальной суммой = {indexMin}");
}

    Console.WriteLine("Ввведите первый размер массива: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввведите второй размер массива: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = GetArray(a, b);
    PrintArray(newArray);
    SumStringArray(newArray);
