// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

Console.WriteLine("Enter b1, k1, b2 and k2 with space: ");
double [] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
double x = (array[0] - array[2]) / (array[3] - array[1]);
Console.WriteLine($"The cross of lines is {x}; {array[1] * x + array[0]}");