Console.Clear();
int length = ImputNumber("Введите количество элементов массива", "Введено неверное значение");
int [] array = new int[length];
PrintArray(array);

void PrintArray(int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива");
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 2)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}