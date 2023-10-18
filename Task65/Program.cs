// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void NaturalNumbersBetweenMandN(int numM, int numN)
{ 
    if (numM>numN) 
    {
        Console.Write($"{numM} ");
        NaturalNumbersBetweenMandN(numM-1, numN);
    }
    
    else if (numM<numN) 
    {
        Console.Write($"{numM} ");
        NaturalNumbersBetweenMandN(numM+1, numN);
    }

    else Console.WriteLine($"{numN} ");
}

int numberM = GetUserInput("Enter the first number: ");
int numberN = GetUserInput("Enter the second number: ");
NaturalNumbersBetweenMandN(numberM, numberN);




