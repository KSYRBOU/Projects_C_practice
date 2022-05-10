//Программа на вход на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N (включительно)

Console.WriteLine("Enter digit:");
int N = int.Parse(Console.ReadLine());
int i = 2;
Console.Write ("Even digits: ");
while (i <= N)
{
    Console.Write (i);
    i = i + 2;
}  


