// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя). 
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Принимаем на вход число (ReadLine принимает только как string)
Console.Write("Enter an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

// Вывести на квадратный уровень
int square = number * number;

// Вывод результата
// Первый метод (нужно учитывать пробелы)
//Console.WriteLine(number + " -> " + square);
// Метод интерполяции:
Console.WriteLine($"{number} -> {square}");
