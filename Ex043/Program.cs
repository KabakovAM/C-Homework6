// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты для функции y = k1 * x + b1:");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициенты  для функции y = k2 * x + b2:");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

void IntersectionPoint(double a1, double c1, double a2, double c2)
{
    double x = Math.Round((c2 - c1) / (a1 - a2), 1, MidpointRounding.ToZero);
    double y = Math.Round((a1 * ((c2 - c1) / (a1 - a2)) + c1), 1, MidpointRounding.ToZero);
    Console.Write($"Координата точки пересечения двух прямых y = {a1} * x + {c1} и y = {a2} * x + {c2} равна ({x}; {y})");
}

IntersectionPoint(k1, b1, k2, b2);