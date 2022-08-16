// Напишити программу, которая принимает на вход чтсло N и выдаёт произведение чисел от 1 до N. (Факториал)
// Вариант 1
Console.WriteLine("Введите число");
int n= int.Parse (Console.ReadLine()?? "");
int f = 1;
while (n > 0)
{
   f = f*n;
   n--;
}
Console.WriteLine($"Факториал числа равен: {f} -> это 1й вариант");
// Вариант 2
int CalculatorFactorial(int num)
{
    int result = 1, i = 1;
    while (i <= num)
    {
        result *= i;
        i ++;
    }
    return result;
}

Console.WriteLine("Введите любое число: ");
int userNumber = int.Parse(Console.ReadLine()??"");
int Factorial = CalculatorFactorial(userNumber);

Console.Write($"Факториал Числа {userNumber} = {Factorial} -> Это 2й вариант");
