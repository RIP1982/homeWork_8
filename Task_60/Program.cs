// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int m = Input("Введите глубина массива: ");
int n = Input("Введите количество строк массива: ");
int l = Input("Введите количество столбцов массива: ");

int maxValumeElements = 89;

Console.WriteLine();

if(m * n * l > maxValumeElements)
{
    Console.WriteLine("Превышение количества элементов массива!");
    return;
}

int[,,] numbers = new int[m,n,l];


FillArray(numbers);
PrintArray(numbers);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] = {array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    int value = 10;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = value;
                value++;
            }
        }
    }
}
