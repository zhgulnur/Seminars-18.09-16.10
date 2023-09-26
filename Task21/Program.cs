// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetUserInput(string message)
{
    Console.Write($"{message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// d = √((хА –  хВ)2 + (уА – уВ)2 + (zA - zB)2)
double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return res;
}

Console.WriteLine("Координаты первой точки:");
int x1 = GetUserInput("Введите координату X: ");
int y1 = GetUserInput("Введите координату Y: ");
int z1 = GetUserInput("Введите координату Z: ");
Console.WriteLine("------------------------------");
Console.WriteLine("Координаты второй точки:");
int x2 = GetUserInput("Введите координату X: ");
int y2 = GetUserInput("Введите координату Y: ");
int z2 = GetUserInput("Введите координату Z: ");


double distance = Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));