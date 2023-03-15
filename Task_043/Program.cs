// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
double b1 = ImputNumber("Введите b1", "Введено неверное значение");
double k1 = ImputNumber("Введите k1", "Введено неверное значение");
double b2 = ImputNumber("Введите b2", "Введено неверное значение");
double k2 = ImputNumber("Введите k2", "Введено неверное значение");
FindPoint(b1,k1,b2,k2);

void FindPoint(double b1, double k1, double b2, double k2)
{
double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых имеет координаты {Math.Round(x, 3)} и {Math.Round(y, 3)}");
}

double ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}