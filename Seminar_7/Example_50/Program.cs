/*  Программа, которая на вход принимает индексы элемента в двумерном массиве,
    и возвращает значение этого элемента или же указание, что такого элемента нет.  */

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
Console.WriteLine($"Массив размером {rows} x {columns}");
int[,] numbers = new int[rows, columns];

FillArray(numbers);
PrintArray(numbers);
FindElement(numbers);

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

void FindElement(int[,] numbers)
{
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row <= rows && column <= columns)
    {
        Console.WriteLine("Значение элемента: " + numbers[row - 1, column - 1]);
    }
    else Console.WriteLine("Такого элемента не существует");
}
