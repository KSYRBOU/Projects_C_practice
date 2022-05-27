//Программа задаёт массив целых чисел и выводит их на экран.
//Размер массива определяется пользователем.

Console.WriteLine("Enter size of array:");
int Number = Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[Number];
int Count = -1;
Number = Number - 1;
while (Count < Number)
{
    Arr[Number] = new Random().Next(1, 10);
    Console.Write(" " + Arr[Number]);
    Number = Number - 1;
} 
