// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day > 0 && day < 6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}