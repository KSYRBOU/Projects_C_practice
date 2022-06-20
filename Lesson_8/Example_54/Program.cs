// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] OrganizedArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    int temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Ввведите первый размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второй размер массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GetArray(a, b);
PrintArray(newArray);
PrintArray(OrganizedArray(newArray));

