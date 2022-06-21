//  Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
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

int[,] MultipyArrays(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            for (int m = 0; m < secondArray.GetLength(1); m++)
            {
                result[i, m] += firstArray[i, j] * secondArray[j, m];
            }
        }
    }
    return result;
}

int[,] newArrayOne = GetArray(2, 2);
int[,] newArrayTwo = GetArray(2, 2);
PrintArray(newArrayOne);
PrintArray(newArrayTwo);
PrintArray(MultipyArrays(newArrayOne, newArrayTwo));
