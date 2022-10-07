// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел вы собираетесь ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArray(numbers);
PositiveNumbersCount(numbers);
Console.WriteLine("Положительных чисел введено: " + count);

void FillArray(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PositiveNumbersCount(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0) count++;
    }
}


