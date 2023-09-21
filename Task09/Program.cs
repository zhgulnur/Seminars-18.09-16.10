// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
int first = number/10;
int second = number%10;

int max = second;
if (first > second) max = first;

// int max = first > second ? first : second;
// Тернарный (тройной) оператор - это то же самое, только одной сторокой (работает как if/else)
// После знака ? (тогда) -> true, а после знака : (иначе) -> false

Console.WriteLine($"{number} -> {max}");

// С помощью функции:

// int maxDigit = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int MaxDigit (int num)
// {
//     int firstDigit = num/10;
//     int secondDigit = num%10;
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }