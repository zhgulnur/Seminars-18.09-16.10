// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

bool IsNumberInArray(int num, int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
       if(arr[i] == num) return true;
    }
    return false;
}


Console.Write("Enter the  number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomArray(5, 1, 999);


string result = IsNumberInArray(number, arr) ? "yes" : "no";
Console.WriteLine($"{number}; array {PrintArray(arr)} -> {result}");