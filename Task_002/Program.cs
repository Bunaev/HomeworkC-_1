Console.WriteLine("Введите первое число");
string user_imput_1 = Console.ReadLine() ?? "";
int user_number1 = int .Parse(user_imput_1);
Console.WriteLine("Введите второе число");
string user_imput_2 = Console.ReadLine() ?? "";
int user_number2 = int .Parse(user_imput_2);
if (user_number1 > user_number2)
{
    Console.WriteLine($"{("Максимальное значение")} - > {(user_number1)}");
    Console.WriteLine($"{("Минимальное значение")} - > {(user_number2)}");
}
else
{
    Console.WriteLine($"{("Максимальное значение")} - > {(user_number2)}");
    Console.WriteLine($"{("Минимальное значение")} - > {(user_number1)}");
}
