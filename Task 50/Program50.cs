// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i, j] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(-10, 10);
    Console.Write($"{array[i, j]} ");
  }
  Console.WriteLine();
}
Console.WriteLine("Введите первую координату:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату:");
int y = Convert.ToInt32(Console.ReadLine());

if (x >= m | y >= n | x < 0 | y < 0)
{
  Console.WriteLine("Такой позиции в массиве нет");
}
else
{
  double result = array[x, y];
  Console.WriteLine($"{result}");
}

   