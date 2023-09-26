// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да

int GetUserInput(string input)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{input}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Palindrome(int numInitial)
{
    int num1 = numInitial / 10000;
    int num2 = (numInitial / 1000) % 10;
    int num4 = (numInitial / 10) % 10;
    int num5 = numInitial % 10;
    return (num1 == num5) && (num2 == num4);
}

int number = GetUserInput("Enter the number");
if (number>=10000 && number<=99999)
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? $"{number} -> yes" : $"{number} -> no");
}
else Console.WriteLine("Input error!");