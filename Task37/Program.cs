// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

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

string PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    return output;
}

int[] Product(int[] array)
{
    int size = array.Length/2 + array.Length%2;
    int[] productOfPairs = new int[size];
    for (int i=0; i < size; i++)
    {
        productOfPairs[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) productOfPairs[size-1] = array[array.Length/2];
    return productOfPairs;
}

int[] arr = RandomArray(6, 1, 9);
int[] result = Product(arr);
Console.WriteLine($"{PrintArray(arr)} -> {PrintArray(result)}");