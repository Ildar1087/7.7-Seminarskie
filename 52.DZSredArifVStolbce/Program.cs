/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
System.Console.Write("введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
Console.WriteLine();
double[] massive = SearchSredArifmetic(array);
PrintArray(massive);


int[,] GetArray(int m, int n)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(0, 10);
      Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();
  }
  return result;
}



double[] SearchSredArifmetic(int[,] array) //функ. для поиска среднего элемента столбца массива
{
  double[] result = new double[array.GetLength(1)];
  double mass = 0;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      mass += array[j, i];
    }
    result[i] = mass / array.GetLength(0); /* делим полученный массив для получения одномерного массива
    со средним значениями элементов старого массива*/ 
    mass = 0;
  }
  return result;
}

void PrintArray(double[] array)
{
   Console.Write("среднее арифметическое элементов в каждом столбце: ");
  for (int i = 0; i < array.Length - 1; i++) // перебираем наш массив для вывода в консоль
  {
    Console.Write($"{array[i]:f1} ");
  }
  Console.WriteLine($"{array[array.Length - 1]:f1} "); // окурглили до одного знака после запятой
}

