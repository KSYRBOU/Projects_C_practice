//Программа выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter digit:");
int num = int.Parse(Console.ReadLine());
int FirstDigit = num / 100;
if (FirstDigit == 0) Console.WriteLine("There is no third digit");
else 
{
    int DigitCount = (int)Math.Log10(num) + 1;
    int Raw = (int)Math.Pow(10, DigitCount - 3);
    int ThirdDigit = (num / Raw) % 10;
    Console.WriteLine("Third digit is: " + ThirdDigit);
}
