// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату X первой точки: ");
int x_first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y_first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z_first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int x_second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y_second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z_second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((x_second - x_first), 2) + Math.Pow((y_second - y_first), 2) + Math.Pow((z_second - z_first), 2))}");
