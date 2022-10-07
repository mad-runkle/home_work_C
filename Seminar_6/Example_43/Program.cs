/*  Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
    значения b1, k1, b2 и k2 задаются пользователем. */

Console.WriteLine("Введите коэффициенты первой прямой");
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициенты второй прямой");
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double pointX = (b2 - b1) / (k1 - k2);
    double pointY = k1 * pointX + b1;
    pointX = Math.Round(pointX, 1);
    pointY = Math.Round(pointY, 1);
    Console.WriteLine($"Прямые пересекаются в точке А({pointX}, {pointY})");
}
else
{
    Console.WriteLine("Прямые параллельны");
}
