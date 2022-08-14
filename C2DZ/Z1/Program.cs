// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите трёхзначное число: ");
int A1 = Convert.ToInt32(Console.ReadLine());
string B1 = Convert.ToString(A1);
Console.WriteLine("Покажем вторую цифру введенного числа: " + A1);
Console.WriteLine("вторая цифра введенного числа -> "+ B1[1]);