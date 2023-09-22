// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SecondDigit(int EnteredNumber)
{
    int TwoDigits = EnteredNumber / 10;
    int OneDigit = EnteredNumber / 100;
    int result = TwoDigits - OneDigit * 10;
    return result;
}

int number = GetUserInput("Enter a three-digit number: ");
int secondDigit = SecondDigit(number);

if (number>=100 && number<=999 || number>=-999 && number<=-100) 
{
    Console.WriteLine($"{number} -> {secondDigit}");
}
else Console.WriteLine("Input error! The number is out of range.");