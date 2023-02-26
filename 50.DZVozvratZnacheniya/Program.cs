/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет      */

System.Console.WriteLine("введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
Console.Write("введите позицию элемента массива для поиска через пробел 3 - строка столбец: ");
string position = Console.ReadLine();
int[] positionIn = InputStringAdress(position);
SearchElement(array, positionIn);



int[,] GetArray(int m, int n) // функция для создания массива
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = i + j;
    }
  }
  return result;
}

void PrintArray(int[,] array) // функция для вывода массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine(""); // переносим следующую строку массива на следующую строку))) тафтология
  }
}


int[] InputStringAdress(string inindex)  // функ. по преобраз. стороки в массив чисел
{
  string[] stringArray = inindex.Split(" ", StringSplitOptions.RemoveEmptyEntries); /* считываем введенное 
    пользователем через пробел */
  int[] result = new int[stringArray.Length];
  for (int i = 0; i < stringArray.Length; i++)
  {
    result[i] = int.Parse(stringArray[i]);
  }
  return result;
}


void SearchElement(int[,] array, int[] position)
{
  if (position[0] >= array.GetLength(0) || position[1] >= array.GetLength(1))
  {
    Console.WriteLine("такого числа в массиве нет!!!");
  }
  else Console.WriteLine($"Это элемент: {array[position[0], position[1]]}");
}


