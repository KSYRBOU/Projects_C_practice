// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Метод наполнения одномерного массива типа string

string[] GetArray(int a)
{
    string[] array = new string[a];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Ведите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Метод печати одномерного массива типа string

void PrintArray(string[] array)
{
    Console.Write("Содержание массива: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

//Метод формирования одномерного массива из строк существующего массива, длинна которых меньше или равна 3 символам

string[] ChangeArray(string[] existArray)
{
    string[] result = new string[existArray.GetLength(0)];
    for (int i = 0; i < existArray.GetLength(0); i++)
    {
        if (existArray[i].Length <= 3)
        result[i] = existArray[i];
    }
    return result;
}

Console.WriteLine("Ввведите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string[] arrResult = GetArray(m);
PrintArray(arrResult);
string[] newResult = ChangeArray(arrResult);
PrintArray(newResult);