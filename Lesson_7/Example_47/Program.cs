// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GetArray(int a, int b)
{
    double[,] array = new double[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 50 - rnd.Next(100) + rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Ввведите первый размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второй размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arrResult = GetArray(m, n);
PrintArray(arrResult);