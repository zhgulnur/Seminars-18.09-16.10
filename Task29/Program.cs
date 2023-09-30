// Напишите программу, которая задаёт массив из
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(100);
    }
    return arr;
}

void PrintArray2(int[] array)
{
    string output = "";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}";
    }
    Console.WriteLine($"{output} -> [{output}]"); ;
}

int[] arr = RandomArray(8);
PrintArray2(arr);
