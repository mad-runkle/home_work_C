/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int size = 12;
int[] numbers = new int[size];
FillArray(numbers, 100, 999);
PrintArray(numbers);
FindEvenNumbers(numbers);

void FillArray(int[] numbers, int minValue, int maxValue)
{
    maxValue++;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "   ");
    }
    Console.WriteLine();
}

void FindEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}
