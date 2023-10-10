// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

string AverageOfColumns(int[,] matrix)
{
    string result = "";
    double sum = 0;
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];

        }
        result += sum/matrix.GetLength(0) + "; ";
    }
    return result;
}

int[,] newMatrix = CreateMatrixRndInt(4, 3, 0, 20);
string result = AverageOfColumns(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine($"Arithmetic mean of each column: {result}");


