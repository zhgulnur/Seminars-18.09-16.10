// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("  |");
    }

}

bool IsThereAnElement(int[,] matrix, int row, int col)
{
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1)) return true;
    else return false;
}


int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] matrix = CreateMatrixRndInt(3, 4, 0, 100);
PrintMatrix(matrix);
int row = GetUserInput("Enter the row");
int column = GetUserInput("Enter the column");


string result = IsThereAnElement(matrix, row, column) ? $"{row}, {column} -> {matrix[row, column]}" : $"{row}, {column} -> there is no such number in the array";

Console.WriteLine(result);


