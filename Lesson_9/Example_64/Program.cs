// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalProgression(int num)
{
    num--;
    Console.Write(num+1);
    if (num > 0)
    {
        NaturalProgression(num);
    }
}
NaturalProgression(number);