//Программа на вход принимает число и 
//выдаёт, является ли число чётным
//делится ли оно на два без остатка.

Console.WriteLine("Enter digit:");
int Digit_1 = int.Parse(Console.ReadLine());
int Result = Digit_1 % 2;
if (Result == 0) Console.WriteLine("The digit is Even.");
else Console.WriteLine("The digit is Odd.");
