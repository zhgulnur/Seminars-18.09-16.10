// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да

int GetUserInput(string input)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{input}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Palindrome(int numInitial)
{
    int num1 = numInitial / 10000;
    int num2 = (numInitial / 1000) % 10;
    int num4 = (numInitial / 10) % 10;
    int num5 = numInitial % 10;
    return (num1 == num5) && (num2 == num4);
}



// Через АВТОТЕСТ
// int number = GetUserInput("Enter the number");
// if (number>=10000 && number<=99999)
// {
//     bool result = Palindrome(number);
//     Console.WriteLine(result ? $"{number} -> yes" : $"{number} -> no");
// }
// else Console.WriteLine("Input error!");


// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       int num1 = number / 10000;
//       int num2 = (number / 1000) % 10;
//       int num4 = (number / 10) % 10;
//       int num5 = number % 10;
//       return (num1 == num5) && (num2 == num4);
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 645464;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine(result ? $"{result}" : $"Число не пятизначное\n{result}");
//     }
// }