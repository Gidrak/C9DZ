// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
int EN = Convert.ToInt32(Console.ReadLine());
string NS = Convert.ToString(EN);
if (NS.Length > 2)
{
    Console.Write("Обнарежена третья цифра  " + NS[2]);
    Console.WriteLine(" - У нас всё получилось");
}
else
{
    Console.WriteLine("третьей цифры не обнаружено, введите трёхзначное число");
}