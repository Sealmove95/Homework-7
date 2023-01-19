// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int j = 0; j < array.GetLength(1); j++)
{
  double average = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    array[i, j] = new Random().Next(-10, 10);
    Console.Write($"{array[i, j]} ");
    average = (average + array[i, j]);
  }
  average = average / n;
  Console.WriteLine();
  Console.Write(Math.Round(average, 2) + "; ");
}
Console.WriteLine();