// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число : ");
int digit = Convert.ToInt32(Console.ReadLine());

  int SumDigit(int digit)
  { 
    int counter = Convert.ToString(digit).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = digit - digit % 10;
      result = result + (digit - advance);
      digit = digit / 10;
    }
   return result;
  }

int sumDigit = SumDigit(digit);
Console.WriteLine("Сумма цифр в числе: " + sumDigit);