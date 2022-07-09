//Задача 62: Заполните спирально массив 4 на 4.

Console.Clear();
int pow = 4;
int column = 4;

int[,] numbers = new int [pow,column];

int value = 1;

//1
for(int j = 0; j < numbers.GetLength(1); j++)
{
     numbers[0,j] = value; 
     value++;
}

//2
value = value - 1;
for(int i = 0; i < numbers.GetLength(0); i++)
{
    numbers[i,3] = value;
    value++;
}

//3
value = value - 1;
for(int j = numbers.GetLength(1) - 1; j >= 0; j--)
{
    numbers[3,j] = value;
    value++; 
}

//4
value = value - 1;
for(int i = numbers.GetLength(0) - 1; i > 0; i--)
{
    numbers[i,0] = value;
    value++;
}

//5
value = value - 1;
for(int j = 0; j < numbers.GetLength(1) - 1; j++)
{
    numbers[1,j] = value;
    value++;
}

//6
value = value - 1;
for(int i = 1; i < numbers.GetLength(0) - 1; i++)
{
    numbers[i,2] = value;
    value++;
}

//7
value = value - 1;
for(int j = numbers.GetLength(1)-2; j > 0; j--)
{
    numbers[2,j] = value;
    value++; 
} 



PrintArray(numbers);

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
   
       for(int j = 0; j < array.GetLength(1); j++)
       {
          Console.Write("{0,3}", array[i,j] + " ");
       }
       Console.WriteLine();
     }
}
