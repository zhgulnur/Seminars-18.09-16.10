// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number*=-1;
int last = number % 10;

if (number >= 100 && number <= 999)
{
    Console.WriteLine($"{number} -> {last}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
