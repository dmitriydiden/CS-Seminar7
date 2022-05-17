/* Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/
using System;
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