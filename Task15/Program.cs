// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Weekend(int day)
{
    return day == 6 || day == 7;
}

int digit = GetUserInput("Enter a digit indicating the day of the week");
bool answer = Weekend(digit);

if (digit<1 || digit>7) Console.WriteLine($"Input error! {digit} is not a digit indicating the day of the week.");
else Console.WriteLine(answer ? $"{digit} -> да" : $"{digit} -> нет");