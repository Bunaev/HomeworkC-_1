Console.Clear();
int number = ImputNumber("Введите пятизначное число");
bool x = (number > 9999 && number < 100000);
    if (x == true)
    {
        FindPalindrome(number);
    }
    else
    {
        Console.WriteLine("Введено неверное число");
    }

// Описание метода FindPalindrome

static void FindPalindrome(int number)
{
int first = 0;
int last = 0;
int second = 0;
int fourth = 0;
first = (number / 10000) % 10;
last = number % 10;
second = (number / 1000) % 10;
fourth = (number / 10) % 10;
bool result = (first == last && second == fourth);
if (result == true)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

// Описание метода ImputNumber

static int ImputNumber(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine() ?? "");
    return n;
}
