﻿// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= number)
{
    Console.WriteLine($"{count} * {count} * {count} = {count * count * count}");
    count++;
}