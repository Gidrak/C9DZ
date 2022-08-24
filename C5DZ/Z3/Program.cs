Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");

PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разница между ними = {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(new Random().Next(10,1000)) / 10;
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
    Console.Write("]");
    Console.WriteLine();
}