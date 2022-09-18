// Программа, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (num > 0)
{
    while (evenNumber <= num)
    {
        Console.Write($"{evenNumber}, ");
        evenNumber = evenNumber + 2;
    }
}
else if (num == 0)
    {
        Console.WriteLine("Вы ввели 0");
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное число");
    }
