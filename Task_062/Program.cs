// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int rows = 4;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);


// Метод для создания двумерного массива на основе введенных данных, заполненного по спирали

int[,] GetArray(int row, int columns)
{
    int[,] arr = new int[row, columns];
    int i = 0; int j = 0; int element = 1;
    while (j < columns - 1)
    {
        arr[i, j] = element;
        element++;
        j++;
    } 
    while (i < row - 1)
    {
        arr[i, j] = element;
        element++;
        i++;
    }
    while (j > 0)
    {
        arr[i, j] = element;
        element++;
        j--;
    }
    while (i > 1)
    {
        arr[i, j] = element;
        element++;
        i--;
    }
    while (j < columns - 2)
    {
        arr[i, j] = element;
        element++;
        j++;
    }
    while (i < rows - 2)
    {
        arr[i, j] = element;
        element++;
        i++;
    }
    while (j > 0)
    {
        arr[i, j] = element;
        element++;
        j--;
    }
    return arr;
}

// Метод для вывода получившегося массива

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < 10)
            {
                Console.Write($"0{arr[i, j]} ");
            }
            else
            {
            Console.Write($"{arr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}



