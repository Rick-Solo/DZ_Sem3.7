// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write("Введите количество строк (m): ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите множител для диапазона (0.0; 1.0) (k): "); //функция возвращает от 0.0 до 1.0, поэтому нужно домножать на произвольное число,
// int k = Convert.ToInt32(Console.ReadLine());                      //чтобы расширить диапозон

// double[,] mass = new double[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         mass[i, j] = new Random().NextDouble() * k;
//         Console.Write("{0:0.000}     ", mass[i, j]);
//     }
//     Console.WriteLine();
// }

// -----------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Перед поиском сздайте массив." + "\n" + "Введите количество строк: ");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int sizeN = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[sizeM, sizeN];
for (int i = 0; i < sizeM; i++)
{
    for (int j = 0; j < sizeN; j++)
    {
        array[i, j] = new Random().Next(0, 1000);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Начинаем поиск элемента" + "\n" + "Введите индекс строк (m): ");
int m = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Введите индекс столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine())-1;

if (m < sizeM && n < sizeN)
{
    Console.WriteLine($"Искомый элемент = {array[m, n]}");
}
else
{
    Console.WriteLine("Tакого числа в массиве нет");
}


// -------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.