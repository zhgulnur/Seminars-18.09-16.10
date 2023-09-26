// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N. 
// 3->1,8,27
// 5 -> 1, 8, 27, 64, 125


void CubeNumbers (int num) 
{
    int count = 1;
    while (count <= num) {
        Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
        count++;
    }
}


Console.WriteLine ("Enter the number:");
int userNum = Convert.ToInt32(Console.ReadLine());
CubeNumbers(userNum);

// Через АВТОТЕСТ

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//       int count = 1;
//       while (count <= N) {
//       Console.WriteLine($"{count*count*count}");
//       count++;
//     }
//     }
// 
// Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 5;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }