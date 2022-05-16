//Программа принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int FirstDigit = num / 100;
int LastDigit = num % 10;
int MiddleDigit = (num - (FirstDigit * 100) - LastDigit) / 10;
Console.WriteLine(MiddleDigit);
