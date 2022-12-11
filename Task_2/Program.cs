// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

double AddNumber(string str)
{
    System.Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double numberB1 = AddNumber(" b1 = ");
double numberK1 = AddNumber(" k1 = ");
double numberB2 = AddNumber(" b2 = ");
double numberK2 = AddNumber(" k2 = ");

double x = Math.Round((numberB2 - numberB1) / (numberK1 - numberK2), 2);   
// k1 * x + b1 = k2 * x + b2 -> (k1 -k2) * x = b2 - b1 -> x = (b2 - b1) / (k1 -k2)
double y = Math.Round((numberK1 * (numberB2 - numberB1) / (numberK1 - numberK2) + numberB1), 2);
// y = k1 * x + b1 -> y = k1 * (b2 - b1) / (k1 -k2) + b1
System.Console.Write($"Точка перечесения прямых - ({x}, {y})");
