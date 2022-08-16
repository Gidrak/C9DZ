// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
string? xyzab = Console.ReadLine();

void CN_xyzab(string xyzab)
{
    if (xyzab[0]==xyzab[4] && xyzab[1]==xyzab[3])
    {
        Console.WriteLine($"Вы угадали: {xyzab} -> является палиндром (да)");
    }
    else
    {
        Console.WriteLine($"Вы не угадали: {xyzab} -> является палиндром (нет)");
    }
}
if (xyzab!.Length == 5)
{
    CN_xyzab(xyzab);
}
else
{
    Console.WriteLine($"Ошибка ВводаБ попробуйте снова ™ + © + € + ‡");
}
