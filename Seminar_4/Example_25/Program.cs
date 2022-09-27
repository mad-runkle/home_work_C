// Используя определение степени числа, напишите цикл,
// который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую необходимо возвести число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"Результат: {result}");
