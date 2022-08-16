int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
Console.WriteLine("Количество цифр в числе");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"\t{num} -> {sumNumbers}");

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