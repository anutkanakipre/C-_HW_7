// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
void SearchArray(int[,] array)
{
    Console.WriteLine("Введите искомое число z - ");
    int z = Convert.ToInt32(Console.ReadLine());
    int find = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (z == array[i, j])
            {
                Console.WriteLine($"Число найдено. Строка {i + 1} Столбец {j + 1}");
                find = 1;
            }
        }
    }
    if (find == 0) Console.WriteLine($"Число {z} не найдено");
}

SearchArray(array);



