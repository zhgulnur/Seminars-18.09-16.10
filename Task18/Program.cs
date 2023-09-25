// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Quater(int QuarterNum)
{
    if(QuarterNum == 1) return "x > 0, y > 0";
    if(QuarterNum == 2) return "x < 0, y > 0";
    if(QuarterNum == 3) return "x < 0, y < 0";
    if(QuarterNum == 4) return "x > 0, y < 0";
    return null;
}
// null - пустая ссылка, значит, в памяти не создана такая запись
// "" - это был бы пустой string, но в памяти все-таки создана такая запись

Console.WriteLine("Enter the quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string range = Quater(quarter);

// if (quarter >= 1 && quarter <=4 ) Console.WriteLine($"This quarter has such range: {range}.");
// else Console.WriteLine("Input Error! Out of range!");

string result = range != null 
                ? $"This quarter has such range: {range}."
                : "Input Error! Out of range.";

Console.WriteLine(result);