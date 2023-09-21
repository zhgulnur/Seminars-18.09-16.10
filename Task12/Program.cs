// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Simple method:

// Console.Write("Enter the first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int left = number1 % number2;

// if (left == 0) Console.WriteLine($"{number1}, {number2} -> кратно");
// else Console.WriteLine($"{number1}, {number2} -> не кратноб остаток {left}");

// С функциями:

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetRemainder(int num1, int num2)
{   
    return num1 % num2;
}

int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum, secondNum);

if (rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondNum}");
}
else
{
    Console.WriteLine($"Число {firstNum} не кратно {secondNum}, остаток {rem}");
}

