// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    int sum = 0;
    int left = 0;
    while (num!=0)
    {
        left = num%10;
        sum += left;
        num = num/10;
    }
    return sum;
}

int number = GetUserInput("Enter the number");
int result = SumOfDigits(number);

Console.WriteLine($"{number} -> {result}");