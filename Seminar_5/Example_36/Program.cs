// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

int size = 8;
int[] numbers = new int[size];
FillArray(numbers, 1, 9);
PrintArray(numbers);
Sum(numbers);

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

void Sum(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i = i + 2)
    {
        sum += numbers[i];
    }
    Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");
}
