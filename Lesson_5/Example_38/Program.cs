// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

Console.WriteLine("Enter size of array:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number <= 0) 
{
    Console.WriteLine("Enter size of array:");
    Number = Convert.ToInt32(Console.ReadLine());
}
double [] Arr = new double[Number];
int Count = -1;
double MaxNumber = Arr[0];
double MinNumber = Arr[0];
double Result = 0;
Number-=1;
while (Count < Number)
{
    Arr[Number] = 50 - new Random().Next(150) + new Random().NextDouble();
    Console.WriteLine(" " + Arr[Number]);
    if (Arr[Number] > MaxNumber) MaxNumber = Arr[Number];
    if (Arr[Number] < MinNumber) MinNumber = Arr[Number];
    Number-=1;
} 
Result = MaxNumber - MinNumber;
Console.WriteLine($"Difference between Max and Min = {Result}");