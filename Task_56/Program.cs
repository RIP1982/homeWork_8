// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


Console.Clear();

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

int[,] numbers = new int [m,n];

if(m == n) 
{
    Console.WriteLine("Введенные данные не соответствуют условию!");
    return;
}

for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
      numbers[i,j] = new Random().Next(1, 10);
   }
}

PrintArray(numbers);

int temp = int.MaxValue;
int k = 0;

for(int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    sum += numbers[i,j];  
   }
   if(sum < temp) 
   {
    temp = sum;
    k = i;
   }
}
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов = {temp} в строке {k}");

       

int Input(string output)
{
   Console.Write(output);
   return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
   
       for(int j = 0; j < numbers.GetLength(1); j++)
       {
          Console.Write(array[i,j] + " ");
       }
       Console.WriteLine();
     }
}