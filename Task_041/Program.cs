//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int length = ImputNumber("Введите число", "Введено неверное значение");
int[] array = new int[length];
int[] usernumbers = PrintArray(array);
FindPositiveNumbers(array);

void FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    bool res = count > 0;
    if (res)
    {
        Console.WriteLine($"Из введенных Вами числел, {count} положительных");
    }
    else
    {
        Console.WriteLine("Среди введенных Вами числел, нет положительных");
    }
}

int[] PrintArray(int[] array)
{
    int length = array.Length;
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return res;
}

int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
