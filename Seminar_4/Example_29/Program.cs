// Программа, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"{col[position]}   ");
    }
}

void SelectionSortMinMax(int[] row)
{
    for (int i = 0; i < row.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < row.Length; j++)
        {
            if (Math.Abs(row[j]) < Math.Abs(row[minPosition]))
            {
                minPosition = j;
            }
        }
        int temporary = row[i];
        row[i] = row[minPosition];
        row[minPosition] = temporary;
    }
}

int size = 8;
int[] numbers = new int[size];
Console.WriteLine("Созданный массив:");
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("\nОтсортированный по модулю массив:");
SelectionSortMinMax(numbers);
PrintArray(numbers);
