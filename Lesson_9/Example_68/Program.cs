// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    } 
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}

Console.WriteLine(recursion(numberM, numberN));