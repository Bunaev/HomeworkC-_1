Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine() ?? "");
    if (num1 < 100)
    {
        Console.WriteLine("Третья цифра в заданном Вами числе отсутсвует");
    }
    else
    {
        while (num1 > 999)
        {
        num1 = num1 / 10;
        }
    num1 = num1 % 10;
    Console.WriteLine(num1);
    }