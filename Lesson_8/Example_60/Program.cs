// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
int[,,] GetArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int l = 0; l < array.GetLength(2); l++)
           {
             int rndNumber = rnd.Next(10, 99);
             if (rndNumber !=  array[i, j, l])
             {
                array[i, j, l] = rndNumber;
             }
           }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write(array[i, j, l] + $" Индекс {i},{j},{l} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] newArray = GetArray(3, 3, 3);

PrintArray(newArray);
