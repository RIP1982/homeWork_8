//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

int[,] numbers = new int [m,n];

for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
      numbers[i,j] = new Random().Next(1, 10);
   }
}

PrintArray(numbers);

int temp;

for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
      for(int k = 0; k < numbers.GetLength(1); k++)
      {
         if(numbers[i,j] > numbers[i,k])
         {
            temp = numbers[i,j];
            numbers[i,j] = numbers[i,k];
            numbers[i,k] = temp;
         }
      }
    }
}
Console.WriteLine();
Console.WriteLine("После сортировки: ");
Console.WriteLine();

PrintArray(numbers);         

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

