// Программа, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.Write("Третья цифра числа: " + result);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}