// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
 
int rows = ImputNumber ("Введите количество строк в массиве: ", "Введено неверное значение");
int columns = ImputNumber ("Введите количество столбцов в массиве: ", "Введено неверное значение");
 
double[,] array = GetArray(rows, columns);
PrintArray(array);
 
//Описание метода GetArray с вещественными числами (не более 2-х знаков после запятой)
 
double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return result;
}
 
// Описание метода PrintArray
 
void PrintArray(double[,] inArray)
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

// Описание метода ImputNumber

int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 1)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}