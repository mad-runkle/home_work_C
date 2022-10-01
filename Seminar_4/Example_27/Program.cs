// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
int result = 0;

while (number > 0)
{
    result += number % 10; //result = result + number % 10;
    number /= 10; //number = number / 10; 
}
Console.WriteLine($"Сумма цифр в числе: {result}");
