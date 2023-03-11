//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int length = ImputNumberForSize("Введите размер массива", "Введено неверное значение");
double[] array = GetDoubleArray(length);
Console.WriteLine($"[{String.Join(", ", array)}]");
double diff = DifferenceMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");


//Описание метода DifferenceMaxMin

double DifferenceMaxMin(double[] array)
{
    int length = array.Length;
    int i = 0;
    double max = array[i];
    double min = array[length - 1];
    for (i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double res = max - min;
    return res;
}

// Описание метода GetArray

double[] GetDoubleArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return res;
}

//Описание метода ImputNumber

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