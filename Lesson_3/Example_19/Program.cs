// Программа принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

int[] Array = new int[5];

Console.WriteLine("Enter 5 digits:");
Console.WriteLine("Enter digit 1:");
Array[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter digit 2:");
Array[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter digit 3:");
Array[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter digit 4:");
Array[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter digit 5:");
Array[4] = int.Parse(Console.ReadLine());

if (Array[0] == Array[4] && Array[1] == Array[3]) Console.WriteLine("You digit is a palindrome!");
else Console.WriteLine("You digit is not a palindrome!"); 
