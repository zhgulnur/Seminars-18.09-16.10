// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter an integer larger than 0: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 2)
{
    int count = 2;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
else if (number>=0 & number<2)
{
    Console.WriteLine("There are no even numbers");
}
else if (number<0)
{
    Console.WriteLine("Input error! The number should be larger than 0.");
}