//Программа принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Enter first digit:");
double Digit_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter second digit:");
double Digit_2 = double.Parse(Console.ReadLine());
if (Digit_1 > Digit_2)
{
    Console.Write("The biggest digit is:");
    Console.WriteLine(Digit_1);
    Console.Write("The smalest digit is:");
    Console.WriteLine(Digit_2);
}
else
{
    Console.Write("The biggest digit is:");
    Console.WriteLine(Digit_2);
    Console.Write("The smalest digit is:");
    Console.WriteLine(Digit_1);
}