Console.Clear();
int number = ImputNumber("Введите число", "Введено неверное значение");
SumOfNumbers(number);

void SumOfNumbers (int number)
{
int num = number;
int result = 0;
while (num > 0)
{
    result = result + num%10;
    num = num/10;
}
Console.WriteLine($"Сумма чисел, содержащихся в числе {number} равна {result}");
}




int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 9)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}