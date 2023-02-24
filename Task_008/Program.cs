Console.WriteLine("Введите число");
string user_imput = Console.ReadLine() ?? "";
int n = int.Parse(user_imput);
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.WriteLine($"{("Четное")} - > {(count)}");
        count++;
    }
    else
    {
        count++;
    }
}
