// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;

int m = 4, n = 3;
int[,] mas = GetArray(m,n);
int sumic = GetSumDiag(mas);
System.Console.WriteLine(sumic);
PrintArray(mas);



int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}


int GetSumDiag(int[,] array)
{
    int ars = array.GetLength(0)<array.GetLength(1) ? array.GetLength(0):array.GetLength(1);
    int summ = 0;
    for (int i = 0; i < ars; i++)
    {
        summ += array[i,i];
    }
    return summ;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

