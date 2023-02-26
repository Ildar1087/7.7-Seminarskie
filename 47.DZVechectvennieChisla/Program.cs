/*  Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */



double[,] RandomArray()
{
  int m = 3;      // колличество строк
  int n = 5;       // количество столбцов
  int minVal = -3; //интервалы заполнения от 
  int maxVal = 11;  //интервал заполнения до

  double[,] newArray = new double[m, n];    //создали новую матрицу заполненную нулями
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      newArray[i, j] = new Random().NextDouble() * (maxVal - minVal) + minVal;
    } // заполнили массив случайными вещественными числами
  }
  return newArray;
}


void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {string.Format("{0:F1}", array[i, j])}"); // округлили выходные числа до десятых
    }
    Console.WriteLine(""); // переносим следующую строку массива на следующую строку))) тафтология
  }
}

double[,] arr2D = RandomArray();
PrintArray(arr2D);
