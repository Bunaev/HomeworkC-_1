Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine() ?? "");

if (num1 >= 1 && num1 <= 7)
{
    bool result = (num1 == 6 || num1 == 7);

    if (result)
    {
        Console.WriteLine("Ура!Выходные!");
    }
    else
    {
        Console.WriteLine("Работай, крестьянин. Солнце еще высоко.");
    }
}
else
{
    Console.WriteLine("Введено неверное число!");
}