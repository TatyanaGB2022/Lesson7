// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25


void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 11);
    }
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

int MaxElement(int[,] array)
{
  int max = array[0, 0];
  foreach (int item in array)
  {
    if (max < item)
    {
      max = item;
    }
  }
  return max;
}

double AverageElements(int[,] array)
{
  double sum = 0;
  foreach (int item in array)
  {
    sum += item;
  }
  return sum / array.Length;
}

int[,] matrix=new int[3,3];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine($"Максимум = {MaxElement(matrix)}");
System.Console.WriteLine($"Среднее = {AverageElements(matrix)}");
(int a, int b) s=(2,3);
System.Console.WriteLine(s.a);