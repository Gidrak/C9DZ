//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Console.Clear();
Console.Write("Введите число: "); 
int cube = Convert.ToInt32(Console.ReadLine()); 
 
void Cube(int[] cube)
{ 
  int totalizer = 0; 
  int length = cube.Length; 
  while (totalizer <  length)
  { 
    cube[totalizer] = Convert.ToInt32(Math.Pow(totalizer, 3)); 
    totalizer++; 
  } 
} 
 
void PrintArry(int[] coll)
{ 
  int count = coll.Length; 
  int index = 0; 
  while(index < count)
  { 
    Console.Write(coll[index]+ " "); 
    index++; 
  } 
}  
int[] arry = new int[cube+1]; 
Cube(arry); 
PrintArry(arry);