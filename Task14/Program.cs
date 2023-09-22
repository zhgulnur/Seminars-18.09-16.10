// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool DivisionTo7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Enter a number");
bool result = DivisionTo7and23(number);

Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");

// Можно сделать так, чтобы вместо 7 и 23 были другие числа:
// bool DivisionTo7and23(int num, int num1, int num2)
// {
//     return num % num1 == 0 && num % num2 == 0;
// }
// потом уже модифицировтаь строки 21,22 (добавить новые введенные числа)