// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int SumOfNumsBetweenMandN(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return m + SumOfNumsBetweenMandN(m + 1, n);
    else return m + SumOfNumsBetweenMandN(m, n + 1);
}

int numberM = GetUserInput("Enter the first number: ");
int numberN = GetUserInput("Enter the second number: ");
Console.WriteLine($"M = {numberM}, N = {numberN} -> {SumOfNumsBetweenMandN(numberM, numberN)}");





