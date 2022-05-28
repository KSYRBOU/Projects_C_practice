// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Console.WriteLine("Enter size of array:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number <= 0) 
{
    Console.WriteLine("Enter size of array:");
    Number = Convert.ToInt32(Console.ReadLine());
}
int[] Arr = new int[Number];
int Count = -1;
int CountForEven = 0;
Number-=1;
while (Count < Number)
{
    Arr[Number] = new Random().Next(100, 1000);
    Console.WriteLine(" " + Arr[Number]);
    if (Arr[Number] % 2 == 0) CountForEven++;
    Number-=1;
} 
Console.WriteLine("Amount of Evens " + CountForEven);