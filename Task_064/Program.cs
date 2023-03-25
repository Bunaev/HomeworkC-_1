//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 
int number = ImputNumber("Введите число N", "Введено неверное значение");
string res = NatNumber(number);
Console.WriteLine($"Число {number} - > {res}");
 
// Описание метода NatNumber
 
string NatNumber(int num)
{
    if (num == 1) return num.ToString();
    return (num + " " + NatNumber(num-1));
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