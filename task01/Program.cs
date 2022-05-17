// Заполнить двумерный массив размером n на m 
using System;
Console.Clear();

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 100);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}

