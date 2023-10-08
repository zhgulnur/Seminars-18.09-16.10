// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int arrLength, int min, int max)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

int HowManyEvenNumbers (int[] array)
{
    int count=0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) count++;
    }
    return count;
}

string PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    return output;
}

int[] arr = RandomArray(4, 100, 999);
int countOfEven = HowManyEvenNumbers(arr);

Console.WriteLine($"{PrintArray(arr)} -> {countOfEven}");