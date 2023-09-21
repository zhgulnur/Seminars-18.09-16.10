// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1*num1 == num2 || num2*num2 == num1;
}

int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");
bool result = IsSquareTwoNumbers(firstNum, secondNum);

Console.WriteLine(result ? $"{firstNum}, {secondNum} -> да" : $"{firstNum}, {secondNum} -> нет");
