// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

int size = 8;
double[] numbers = new double[size];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {FindMax(numbers) - FindMin(numbers)}");


void FillArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        double random = new Random().Next(-1000, 1000);
        double rnd = new Random().Next(17, 19);
        numbers[i] = Math.Round(random / rnd, 2);
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "   ");
    }
    Console.WriteLine();
}

double FindMax(double[] numbers)
{
    double maxNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }
    Console.WriteLine("Максимальный элемент массива: " + maxNumber);
    return maxNumber;
}

double FindMin(double[] numbers)
{
    double minNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < minNumber)
        {
            minNumber = numbers[i];
        }
    }
    Console.WriteLine("Минимальный элемент массива: " + minNumber);
    return minNumber;
}

