// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] array = new int[random.Next(1, 5), random.Next(1, 5)];
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, j] = random.Next(1, 5);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Количество строк в столбце {array.GetLength(1)}");

for (int j = 0; j < array.GetLength(0); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[j, i];
    }
    Console.Write($"сумма по столбцам {sum}  ");
    double result = Math.Round((sum / array.GetLength(1)), 2);
    Console.WriteLine($"среднеарифметическое - {result} ");
}
Console.ReadLine();
