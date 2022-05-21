// Программа принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

// Метод определения палиндрома
string Check_Palindrome(int FirstDigit, int SecondDigit, int ThirdDigit, int ThourthDigit, int FithDigit)
{;
    string A = "You digit is a palindrome!";
    string B = "You digit is not a palindrome!";
    if (FirstDigit == FithDigit && SecondDigit == ThourthDigit) return A;
    else return B;
}

int[] Array = new int[5];

Console.WriteLine("Enter 5 digits:");
Console.WriteLine("Enter digit 1:");
Array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter digit 2:");
Array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter digit 3:");
Array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter digit 4:");
Array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter digit 5:");
Array[4] = Convert.ToInt32(Console.ReadLine());

string Result = Check_Palindrome(Array[0], Array[1], Array[2], Array[3], Array[4]);

Console.WriteLine(Result);
