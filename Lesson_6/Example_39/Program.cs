// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Enter number of array with space:");
int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
//Console.WriteLine(String.Join(" ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine("Total amount of numbers > 0: " + count);