// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое число элементов в каждом столбце.

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
Console.WriteLine($"Массив размером {rows} x {columns}");
int[,] numbers = new int[rows, columns];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Среднее арифметическое число элементов в каждом столбце:");
Average(numbers);

void FillArray(int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Average(int[,] numbers)
{
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
        average = sum / rows;
        average = Math.Round(average, 1);
        Console.Write(average + "\t");
    }
}
