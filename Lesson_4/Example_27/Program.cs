//Программа принимает на вход число и выдаёт сумму 
//цифр в числе. Задачу решить без использования строк (string).

Console.WriteLine("Enter number:");
int Number = int.Parse(Console.ReadLine());
int Result = 0;
while (Number > 0)
{
    Result = Result + (Number % 10);
    Number = Number / 10;
}
Console.WriteLine($"The sum of digits is {Result}");
