// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Enter a number: ");
string a = Console.ReadLine();

if (a == "1")
{
    Console.WriteLine($"{a} -> Monday");
}

else if (a == "2")
{
    Console.WriteLine($"{a} -> Tuesday");
}

else if (a == "3")
{
    Console.WriteLine($"{3} -> Wednesday");
}

else if (a == "4")
{
    Console.WriteLine($"{a} -> Thursday");
}

else if (a == "5")
{
    Console.WriteLine($"{a} -> Friday");
}

else if (a == "6")
{
    Console.WriteLine($"{a} -> Saturday");
}

else if (a == "7")
{
    Console.WriteLine($"{a} -> Sunday");
}

else
{
    Console.Write("Error! Out of range.");
}