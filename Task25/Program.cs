// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Degree (int numA, int numB)
{
    int degree = 1;
    for (int i=0; i<numB; i++)
    {
        checked
        {
            degree *= numA;
        }
    }
    return degree;
}



int numberA = GetUserInput("Enter the first number");
int numberB = GetUserInput("Enter the second number");
int result = Degree(numberA, numberB);

Console.WriteLine($"{numberA}, {numberB} -> {result} ({numberA}^{numberB})");