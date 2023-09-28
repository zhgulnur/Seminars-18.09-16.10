// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
 
// 4 -> 24 
// 5 -> 120


int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Factorial(int count)
{
    int sum = 1;
    for (int i=1; i<=count; i++)
    {
        checked
        {
            sum *= i;
        }

    }
    return sum;
}

int number = GetUserInput("Enter a number");
int sumNumbers = Factorial(number);

Console.WriteLine($"{number} -> {sumNumbers}");


