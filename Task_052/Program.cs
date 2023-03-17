// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int rows = new Random().Next(3, 15);
int columns = new Random().Next(3, 15);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Average(array, rows, columns);

// Описание метода GetArray

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Описание метода PrintArray

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Описание метода Average 

void Average(int[,] inArray, int m, int n)
{
    for (int j = 0; j < n; j++)
    {
        double avr = 0;
        for (int i = 0; i < m; i++)
        {
            avr = (avr + inArray[i, j]);
        }
        avr = Math.Round(avr / m, 2);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {avr}");
    }
}