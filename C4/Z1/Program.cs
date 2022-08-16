// Напишите прогамму, которая на входе принимает число и выдает количество цифр в числе.
// 1й вариант
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
Console.WriteLine("Количество цифр в числе");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"\t{num} -> {sumNumbers} -> Это был 1й вариант");

int GetNumberFromUser(string message, string errorMessage)
{
     while(true)
     {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
     } 
}
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum ++;
        number /= 10;  
    } 
    return sum;  
}
// 2й вариант
int number;

int CounNember(int num)
{
    int i = 0;
    while(num > 0)
    {
        num /= 10;
        i++;
    }
    return i;
}
Console.WriteLine("Введите любое число: ");
number = int.Parse(Console.ReadLine()??"");
number = CounNember(number);
Console.WriteLine($"Число состоит из {number} цифр -> А это 2й");