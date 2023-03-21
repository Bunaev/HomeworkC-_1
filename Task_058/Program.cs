// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int minValue1 = ImputNumberValue("Введите минимальное число первой матрицы - ", "Ошибка ввода");
int maxValue1 = ImputNumberValue("Введите максимальное число первой матрицы - ", "Ошибка ввода");
int rows1 = ImputNumberSize("Введите количество строк первой матрицы - ", "Ошибка ввода");
int columns1 = ImputNumberSize("Введите количество столбцов первой матрицы - ", "Ошибка ввода");

int minValue2 = ImputNumberValue("Введите минимальное число второй матрицы - ", "Ошибка ввода");
int maxValue2 = ImputNumberValue("Введите максимальное число второй матрицы - ", "Ошибка ввода");
int rows2 = ImputNumberSize("Введите количество строк второй матрицы - ", "Ошибка ввода");
int columns2 = ImputNumberSize("Введите количество столбцов второй матрицы - ", "Ошибка ввода");
if (columns1 != rows2)
{
    Console.WriteLine("Перемножение введеных Вами матриц невозможно");
}
else
{
    int[,] array1 = GetArray(rows1, columns1, minValue1, maxValue1);
    int[,] array2 = GetArray(rows2, columns2, minValue2, maxValue2);

    Console.WriteLine();
    Console.WriteLine("Первая матрица:");
    PrintArray(array1);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица:");
    PrintArray(array2);
    int[,] result = new int[rows2, columns1];
    MatrixProduct(array1, array2, result);
    Console.WriteLine();
    Console.WriteLine("Произведение введенных матриц:");
    PrintArray(result);
}

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

// Массив для перемножения двух матриц

void MatrixProduct(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i,k]*matrix2[k,j];
            }
            resultMatrix[i,j] = sum;
        }
}