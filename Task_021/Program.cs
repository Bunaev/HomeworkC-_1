Console.Clear();
int x1 = InputNumber("Введите х1: ");
int y1 = InputNumber("Введите у1: ");
int z1 = InputNumber("Введите z1: ");
int x2 = InputNumber("Введите х2: ");
int y2 = InputNumber("Введите у2: ");
int z2 = InputNumber("Введите z2: ");

Console.WriteLine($"Расстояние между точками c координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) {CalculateDistance(x1, y1, x2, y2, z1, z2)}");


static int InputNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.Write(message);
            return (n = int.Parse(Console.ReadLine() ?? ""));
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
            return 0;
        }
    }
}

static double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}