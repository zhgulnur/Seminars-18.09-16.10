﻿// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0)
{
    Console.WriteLine("Input error!");
    return;
}
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers(num-1);
    Console.Write($"{num} ");
}