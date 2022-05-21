// Программа принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter digit:");
int N = int.Parse(Console.ReadLine());
int i = 1;
int degree = 3;
Console.Write ("Cubes for digits: ");
while (i <= N)
{
    Console.Write(" " + Math.Pow(i, degree));
    i = i + 1;
}  