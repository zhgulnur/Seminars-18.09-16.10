// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Sum(int count)
{
    int sum = 0;
    for (int i=1; i<=count; i++)
    {
        checked
        {
            sum += i;
        }

    }
    
    return sum;
}

int number = GetUserInput("Enter a number");
int sumNumbers = Sum(number);

Console.WriteLine($"{number} -> {sumNumbers}");


