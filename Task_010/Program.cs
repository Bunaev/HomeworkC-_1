Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine() ?? "");
if (num1 < 100 || num1 > 999)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    num1 = num1 / 10;
    num1 = num1 % 10;
    Console.WriteLine($"Второе число - {num1}");
}