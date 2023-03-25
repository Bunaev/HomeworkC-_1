//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 
int numberM = ImputNumber("Введите число M", "Введено неверное значение");
int numberN = ImputNumber("Введите число N", "Введено неверное значение");
int res = SumNatNumber(numberM, numberN);
Console.WriteLine($"Сумма натуральных числел, находящихся между числами {numberM} и {numberN} - > {res}");
 
// Описание метода SunNatNumber
 
int SumNatNumber(int num1, int num2)
{
    if (num1 == num2+1) return 0;
    return num1 + SumNatNumber(num1+1, num2);
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