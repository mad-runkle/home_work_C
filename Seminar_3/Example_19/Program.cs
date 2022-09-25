// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int first_element = number / 10000;
    int second_element = number / 1000 % 10;
    int four_element = number / 10 % 10;
    int fifth_element = number % 10;
    
    if (first_element == fifth_element && second_element == four_element)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}

