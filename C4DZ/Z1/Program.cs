// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int Exponentiation(int digitA, int digitB){
  int result = 1;
  for(int i=1; i <= digitB; i++)
  {
    result = result * digitA;
  }
    return result;
}

  Console.Write("Введите число (A) возводимое в степень : ");
  int digitA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число (B) в какую степень : ");
  int digitB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(digitA, digitB);
  Console.WriteLine("Результат: " + exponentiation);
