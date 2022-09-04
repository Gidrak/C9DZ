// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
ChegStrigRevers(numbers);
Console.WriteLine();
PrintArray(numbers);

void ChegStrigRevers(int[,] numbers)
{
    int nRows = numbers.GetLength(0);
    int mCol = numbers.GetLength(1);
    if (nRows == mCol)
    {
        int temp = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; i < m; i++)
            {
                temp = numbers[i, k];
                numbers[i, k] = numbers[k, i];
                numbers[k, i] = temp;
            }
        }
    }
    else 
    {   
        Console.WriteLine("Транспонирование невозможно! ");
    }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
