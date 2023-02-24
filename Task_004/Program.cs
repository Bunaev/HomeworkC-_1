Console.WriteLine("Введите первое число");
string user_imput_1 = Console.ReadLine() ?? "";
int user_number1 = int .Parse(user_imput_1);
Console.WriteLine("Введите второе число");
string user_imput_2 = Console.ReadLine() ?? "";
int user_number2 = int .Parse(user_imput_2);
Console.WriteLine("Введите третье число");
string user_imput_3 = Console.ReadLine() ?? "";
int user_number3 = int .Parse(user_imput_3);
int max = user_number1;
if (user_number2 > max)
{
    max = user_number2;
}
if (user_number3 > max)
{
    max = user_number3;
}
Console.WriteLine($"{("Максимальное значение")} - > {(max)}");