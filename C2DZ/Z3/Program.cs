// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введи цифру, деня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7) 
{
  Console.WriteLine("(Сегодня выходной, дай поспать.)");
}
else if (dayWeek < 1 || dayWeek > 7) {
  Console.WriteLine("Ошибочно пологать, что введено правильное значение");
}
else Console.WriteLine("(Опять работать)");
