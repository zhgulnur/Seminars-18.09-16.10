// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfOddPositionNumbers (int[] array)
{
    int sum=0;
    for (int i=1; i < array.Length; i = i +2)
    {
        sum += array[i];
    }
    return sum;
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

int[] arr = RandomArray(4, -99, 99);
int result = SumOfOddPositionNumbers(arr);

Console.WriteLine($"{PrintArray(arr)} -> {result}");