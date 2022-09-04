// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
ChegStrig(numbers);
Console.WriteLine();
PrintArray(numbers);

void ChegStrig(int[,] numbers)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        temp = numbers[n - 1, i];
        numbers[n - 1, i] = numbers[0, i];
        numbers[0, i] = temp;
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
