//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 
int numberM = ImputNumber("Введите число M", "Введено неверное значение");
int numberN = ImputNumber("Введите число N", "Введено неверное значение");
int res = Akkerman(numberM, numberN);
Console.WriteLine($"A ({numberM},{numberN}) - > {res}");
 
// Описание метода Akkerman
 
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
 
// Описание метода ImputNumber
 
int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >=0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}