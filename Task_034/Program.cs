//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int length = ImputNumberForSize("Введите размер массива", "Введено неверное значение");
int min = ImputNumberForMassive("Введите минимальный трехзначный элемент", "Введено неверное значение");
int max = ImputNumberForMassive("Введите максимальный трехзначный элемент", "Введено неверное значение");
int[] array = GetArray(length, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");
int count = FindEvenNumbers(array);
if (count == 0)
{
    Console.WriteLine("В заданом массиве отсутствуют четные элементы");
}
else
{
    Console.WriteLine($"В заданом массиве {count} четных элементов");
}

// Описание метода FindEvenNumbers

int FindEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            count++; ;
    }
    return count;
}

// Описание метода GetArray

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//Описание метода ImputNumber

int ImputNumberForMassive(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 100 && userNumber <= 999)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int ImputNumberForSize(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 2)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}