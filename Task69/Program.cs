// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int DegreeOfNumber(int a, int b)
{
    if (b==0) return 1;
    return a * DegreeOfNumber(a, b-1);
}

int numA = GetUserInput("Enter the number A: ");
int numB = GetUserInput("Enter the number B: ");
Console.WriteLine($"{numA}^{numB} = {DegreeOfNumber(numA, numB)}");