Console.Clear();
int number = ImputNumber("Введите число");
FindCube(number);

static void FindCube(int number)
{
int count = 1;
int result = 0;
while (count < number)
{
    if (count < number)
    {
        result = count*count*count;
        Console.WriteLine($"Таблица кубов числа {number} из числа {count} - > {result}");
        count++;
    }
}
}


static int ImputNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ошибка ввода");
        }
    }
    return n;
}
    