// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

int m = Input("Введите количество строк первого массива: ");
int n = Input("Введите количество столбцов первого массива, строк второго массива: ");
int l = Input("Введите количество столбцов второго массива: ");

int[,] firstArray = new int[m, n];
int[,] secondArray = new int[n, l];

FillArray(firstArray);
FillArray(secondArray);

int[,] thirdArray = new int[m, l];

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            thirdArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
    Console.WriteLine();
}

PrintArray(firstArray);
Console.WriteLine("*");
PrintArray(secondArray);
Console.WriteLine("=");
PrintArray(thirdArray);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}