//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int minValue = ImputNumberValue("Введите минимальное число массива - ", "Ошибка ввода");
int maxValue = ImputNumberValue("Введите максимальное число массива - ", "Ошибка ввода");

int rows = ImputNumberSize("Введите количество строк массива - ", "Ошибка ввода");
int columns = ImputNumberSize("Введите количество столбцов массива - ", "Ошибка ввода");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int[] SumRowsArray = SumRowMassive(array, rows);
Console.WriteLine();
FindMinRow(SumRowsArray);

// Метод запроса ввода для любого целого числа

int ImputNumberValue(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Метод запроса ввода для любого положительного целого числа >= 2

int ImputNumberSize(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 2)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Метод для создания двумерного массива на основе введенных данных

int[,] GetArray(int row, int columns, int min, int max)
{
    int[,] arr = new int[row, columns];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(min, max + 1);
    return arr;
}

// Метод для вывода получившегося массива

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для создания одномерного массива, состоящего из сумм элементов строк

int[] SumRowMassive(int[,] inArray, int m)
{
    int[] res = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = (sum + inArray[i, j]);
            res[i] = sum;
        }
    }
    return res;
}

// Метод для поиска индекса минимального значения в одномерном массиве

void FindMinRow(int[] array)
{   
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"В строке № {index + 1} установлена минимальная сумма элементов равная - {min}");
}