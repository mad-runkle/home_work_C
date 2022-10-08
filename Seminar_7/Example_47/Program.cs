// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами, округлёнными до одного знака.

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
Console.WriteLine($"Массив размером {rows} x {columns}");
double[,] numbers = new double[rows, columns];

FillArrayDouble(numbers);
PrintArrayDouble(numbers);

void FillArrayDouble(double[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.NextDouble() * 20 - 10;
            numbers[i, j] = Math.Round(numbers[i, j], 1);
        }
    }
}

void PrintArrayDouble(double[,] numbers)
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
