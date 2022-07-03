﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Ввведите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string[] arrResult = GetArray(m);
PrintArray(arrResult);