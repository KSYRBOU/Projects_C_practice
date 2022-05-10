//Программа принимает на вход три числа
//и выдаёт максимальное из этих чисел

Console.WriteLine("Enter first digit:");
double Digit_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second digit:");
double Digit_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third digit:");
double Digit_3 = int.Parse(Console.ReadLine());
double Max_Digit = Digit_1;

if (Digit_2 > Digit_1) Max_Digit = Digit_2;
if (Digit_3 > Digit_2) Max_Digit = Digit_3;
Console.Write("Max digit:");
Console.WriteLine(Max_Digit);