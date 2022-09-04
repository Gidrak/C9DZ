// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int N = InputNumbers("Введите N: ");
int count = 2;
Console.Write($"N = " + $"{N}" + " ---> ");
PrintNumber(N, count);
Console.Write(1);

void PrintNumber(int N, int count)
{
  if (count > N) return;
  PrintNumber(N, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}