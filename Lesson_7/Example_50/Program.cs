// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

void CheckArray(int[,] array, int a1, int b1)
{
    if (a1 >= array.GetLength(0) ^ b1 >= array.GetLength(1)) Console.Write("Такого элемента массива не существует!");
    else Console.Write($"Значение элемента массива = {array[a1, b1]}");
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
       
}

int m = new Random().Next(2, 10);
int n = new Random().Next(3, 10);

Console.WriteLine("Введите первое число позиции элемента двумерного массива: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число позиции элемента двумерного массива: ");
int b1 = Convert.ToInt32(Console.ReadLine());

int [,] arrResult = GetArray(m, n);
PrintArray(arrResult);
CheckArray(arrResult, a1, b1);