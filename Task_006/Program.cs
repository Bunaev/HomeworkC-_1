Console.WriteLine("Введите число");
string user_imput_1 = Console.ReadLine() ?? "";
int n = int.Parse(user_imput_1);
if (n % 2 == 0)
{
    Console.WriteLine("Ваше число - четное");
}
else
{
    Console.WriteLine("Ваше число - нечетное");
}