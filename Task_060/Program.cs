// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.Clear();
int minValue = ImputNumberValue("Введите минимальное двузначное число в массиве - ", "Ошибка ввода");
int maxValue = ImputNumberValue("Введите максимальное двузначное число в массиве - ", "Ошибка ввода");
int sizeX = ImputNumberSize("Введите количество строк - ", "Ошибка ввода");
int sizeY = ImputNumberSize("Введите количество столбцов - ", "Ошибка ввода");
int sizeZ = ImputNumberSize("Введите количество символов по оси Z - ", "Ошибка ввода");
 
int[,,] array = GetArray3D (sizeX, sizeY, sizeZ, minValue, maxValue);
Console.WriteLine();
PrintArray3D(array);
 
// Метод запроса ввода для любого целого числа
 
int ImputNumberValue(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 9 && userNumber < 100)
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
 
// Метод для создания трехмерного массива на основе введенных данных с неповторяющимися числами
 
int[,,] GetArray3D(int x, int y, int z, int min, int max)
{
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
        {
            int k = 0;
            while (k < z)
            {
                int element = new Random().Next(min, max + 1);
                if (ElementComparison(arr, element))
                {
                continue;
                }
                else
                {
                arr[i, j, k] = element;
                k++; 
                }
            }
        }
    return arr;
}
 
// Метод для вывода получившегося массива
 
void PrintArray3D(int[,,] arr)
{   
    for (int k = 0; k < arr.GetLength(2); k++)
    {    
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
            Console.Write($"{arr[i,j,k]} - ({i}, {j}, {k}) ");
            }
        Console.WriteLine();
        }
    }
}
 
// Логический метод для сравнения элементов массива
bool ElementComparison(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) 
                return true;
            }
        }
    }
    return false;
}
