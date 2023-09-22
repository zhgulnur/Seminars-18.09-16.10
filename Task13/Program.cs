// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int ThirdDigit(int EnteredNumber)
{
    while (EnteredNumber >=1000) EnteredNumber /= 10;
    
    int DivisionTo10 = EnteredNumber / 10;
    int NeededDigit = EnteredNumber - DivisionTo10 * 10;
    return NeededDigit;
}


int number = GetUserInput("Enter a number");
int NumberForCalculation = number;
if (NumberForCalculation<0) NumberForCalculation *= -1;

int thirdDigit = ThirdDigit(NumberForCalculation);
if (NumberForCalculation >= -99 && NumberForCalculation <= 99) Console.WriteLine($"{number} -> there is no third digit");
else Console.WriteLine($"{number} -> {thirdDigit}");