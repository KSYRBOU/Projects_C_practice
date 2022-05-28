// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

Console.WriteLine("Enter size of array:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number <= 0) 
{
    Console.WriteLine("Enter size of array:");
    Number = Convert.ToInt32(Console.ReadLine());
}
int[] Arr = new int[Number];
int Count = -1;
Number-=1;
int Sum = 0;
while (Count < Number)
{
    Arr[Number] = new Random().Next(1, 10000);
    Console.WriteLine(" " + Arr[Number]);
    Number-=1;
}
for (int i = 1; i < Arr.Length; i+=2)
{
    Sum += Arr[i];
}
Console.WriteLine($"Amount of Ods = {Sum}");