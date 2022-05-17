/* Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.*/
using System;
Console.Clear();

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int [,] matrix = new int[m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= (i+1)+(j+1);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}