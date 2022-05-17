/* Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.*/
using System;
Console.Clear();
int[,] startArray = GetRandomArray(4,4,1,10);
PrintArray(startArray);
Console.WriteLine(GetSumDiag(startArray));


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

int GetSumDiag(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum+=array[i,i];        
    }
    return sum;
}
