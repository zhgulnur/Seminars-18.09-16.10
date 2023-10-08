// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] RandomArray(int arrLength, int min, int max)
{
    double[] arr = new double[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

double MinimumNumber (double[] array)
{
    double minNumber=array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}

double MaximumNumber (double[] array)
{
    double maxNumber=array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}


string PrintArray(double[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    return output;
}

double[] arr = RandomArray(4, 0, 99);
double minimum = MinimumNumber(arr);
double maximum = MaximumNumber(arr);

Console.WriteLine($"{PrintArray(arr)} => {maximum} - {minimum} = {maximum-minimum}");