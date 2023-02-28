Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine() ?? "");
int result = 0;
int result1 = 0;
int result3 = 0;
if (num1 < 10000)
{
    if (num1 < 1000)
    {
        if (num1 < 100)
        {
            Console.WriteLine("Третья цифра в заданном Вами числе отсутсвует");
        }
        else
        {
            result = num1 % 10;
            Console.WriteLine(result);
        }
    }
    else
    {
        result1 = (num1 / 10) % 10;
        Console.WriteLine(result1);
    }
}
else
    {
        result3 = (num1 / 100) % 10;
        Console.WriteLine(result3);
    }