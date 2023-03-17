// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
 
int rows = new Random().Next(3, 15);
int columns = new Random().Next(3, 15);
 
int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);
Console.WriteLine();
int FindNum = FindPosition(array);
if (FindNum == 0)
{
    Console.WriteLine("По указанным Вами индексам - элементы отсутсвуют");
}
else
{
    Console.WriteLine($"По указанным Вами индексам найден элемент: {FindNum}");
}
 
 
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
 
// Метод по поиску строки и столбца
 
int FindPosition(int[,] inArray)
{
    int rows = ImputNumber ("Введите строку для поиска элемента: ", "Введено неверное значение");
    int columns = ImputNumber ("Введите столбец для поиска элемента: ", "Введено неверное значение");
    int FindNumber = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            bool res = (rows == i && columns == j);
            if (res)
            {
                FindNumber = inArray[i, j];
                return FindNumber;
            }
        }
    }
    return FindNumber;
}

// Описание метода ImputNumber

int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}