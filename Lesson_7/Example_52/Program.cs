// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
int [,] GetArray(int a, int b)
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

void SumOfArrayRows(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j]; 
        }
        Console.Write(+ Math.Round((sum / array.GetLength(0)), 2) + " ");
    }
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

Console.WriteLine("Ввведите первый размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второй размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arrResult = GetArray(m, n);
PrintArray(arrResult);
SumOfArrayRows(arrResult);