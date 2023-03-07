int numberA = ImputNumber("Введите первое число", "Введено неверное значение");
int numberB = ImputNumber("Введите второе число", "Введено неверное значение");
DegreeNumber(numberA, numberB);

// Описание метода DegreeNumber

void DegreeNumber(int num1, int num2)
{
    int result = 1;
    for (int count = 1; count <= num2; count++)
    {
        result = result * num1;
    }
    Console.WriteLine(result);
}

// Описание метода ImputNumber

int ImputNumber(string message, string errorMessage)
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