//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. Задачу решить без использования Math.Pow.

Console.WriteLine("Enter digit 1:");
int D1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter digit 2:");
int D2 = int.Parse(Console.ReadLine());

int Result = D1;
int i = 2;
while (i <= D2)
{
    Result = Result * D1;
    i++;
}  
Console.WriteLine($"The {D2} degree of {D1} = {Result}");