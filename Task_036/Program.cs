//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int length = ImputNumberForSize("Введите размер массива", "Введено неверное значение");
int min = ImputNumberForMassive("Введите минимальный элемент массива", "Введено неверное значение");
int max = ImputNumberForMassive("Введите максимальный элемент массива", "Введено неверное значение");
int[] array = GetArray(length, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");
int OddSum = FindOddSum(array);
Console.WriteLine($"Сумма всех нечетных элементов массива = {OddSum}");

// Описание метода FindOddSum

int FindOddSum(int[] array)
{
    int sum = 0;
    foreach (int el in array)
    {
        if (el % 2 != 0)
            sum+=el;
    }
    return sum;
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
        if (isCorrect)
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