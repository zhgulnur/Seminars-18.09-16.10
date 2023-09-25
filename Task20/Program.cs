// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Length(int coordX1, int coordX2, int coordY1, int coordY2)
{
    double first = Math.Pow((coordX1-coordX2), 2);
    double second = Math.Pow((coordY1-coordY2), 2);
    double third = Math.Sqrt((first+second));
    double fourth = Math.Round(third, 2, MidpointRounding.ToZero);
    return fourth;
}

Console.WriteLine("Enter the coordinate points");
Console.Write("X for the point A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y for the point A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X for the point B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y for the point B: ");
int y2= Convert.ToInt32(Console.ReadLine());

double length = Length(x1, x2, y1, y2);

Console.WriteLine($"A ({x1}, {y1}); B ({x2}, {y2}) -> {length}");