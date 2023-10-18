// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int AckermannFunction(int n, int m)
{
    if (n == 0) return m+1;
    else if (m == 0) return AckermannFunction(n-1, 1);
    else return AckermannFunction(n-1, AckermannFunction(n, m-1));
}

int numberM = GetUserInput("Enter the first number: ");
int numberN = GetUserInput("Enter the second number: ");
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {AckermannFunction(numberN, numberM)}");