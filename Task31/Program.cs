// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.



int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    Console.WriteLine(output);
}

int SumOfPositives(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positive += array[i];
    }
    return positive;
}

int SumOfNegatives(int[] array)
{
    int negative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) negative += array[i];
    }
    return negative;
}

int[] arr = RandomArray(12);
PrintArray(arr);
// int positive = SumOfPositives(arr);
// int negative = SumOfNegatives(arr);

// Console.WriteLine($"Sum of Positive Numbers = {positive}");
// Console.WriteLine($"Sum of Negative numbers = {negative}");

// а можно через один метод (возвращение одномерного массива):
int[] SumOfPositivesAndNegatives(int[] array)
{
    int positive = 0;
    int negative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positive += array[i];
        else negative += array[i];
    }
    return new int[] {positive, negative};
}

int[] sums = SumOfPositivesAndNegatives(arr);
Console.WriteLine($"Sum of Positive Numbers = {sums[0]}");
Console.WriteLine($"Sum of Negative numbers = {sums[1]}");