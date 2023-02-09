//  Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int CountSum(int[,] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    sum = sum + arr[i, i];
  }
  return sum;
}

bool ValidateArray(int[,] arr)
{
  if (arr.GetLength(0) != arr.GetLength(1))
  {
    Console.WriteLine("Матрица не квадратная!) ");
    return false;
  }
  return true;
}

int[,] matrix = new int[3, 3];
if (ValidateArray(matrix))
{
  FillArray(matrix);
  PrintArray(matrix);
  int summ = CountSum(matrix);
  Console.WriteLine($"Cумма главной диагонали равна {summ}");
}