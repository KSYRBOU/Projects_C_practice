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

Console.WriteLine("Enter 5 digits number:");
int Number = Convert.ToInt32(Console.ReadLine());

Array[0] = (Number - (Number % 10000)) / 10000;
Array[1] = (((Number - (Number % 1000)) / 1000) % 10);
Array[2] = (((Number - (Number % 100)) / 100) % 10);
Array[3] = (((Number - (Number % 10)) / 10) % 10);
Array[4] = Number % 10;

string Result = Check_Palindrome(Array[0], Array[1], Array[2], Array[3], Array[4]);

Console.WriteLine(Result);
