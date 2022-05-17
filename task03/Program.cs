/* Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

// Моё решение
/*using System;
Console.Clear();

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[n,m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().Next(0,10);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if ((i % 2 == 0) && (j % 2 == 0))
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.Write($"{matrix[i, j]} ");
        }
        else Console.Write($"{matrix[i, j]} ");
    }

    Console.WriteLine();
}
*/

// Решение Тимура
using System;
Console.Clear();
int[,] startArray = GetRandomArray(4,4,1,10);
PrintArray(startArray);
Console.WriteLine();
startArray = ChangeArray(startArray);
PrintArray(startArray);

int[,] GetRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i>0 && i%2==0 && j>0 && j%2 ==0)
            {
                array[i,j]*=array[i,j];
            }
        }
        
    }
    return array;
}