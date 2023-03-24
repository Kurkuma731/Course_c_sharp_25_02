﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; // создаем двумерный массив

int rows = arr.GetLength(0); // количество строк в массиве
int cols = arr.GetLength(1); // количество столбцов в массиве

double[] averages = new double[cols]; // создаем массив для хранения средних значений по столбцам

// проходимся по столбцам массива и находим среднее арифметическое для каждого столбца
for (int j = 0; j < cols; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += arr[i, j];
    }
    averages[j] = sum / rows; // находим среднее значение и записываем его в массив
}

// выводим средние значения на экран
Console.WriteLine("Среднее арифметическое по столбцам:");
for (int j = 0; j < cols; j++)
{
    Console.Write($"{averages[j]:F1}\t"); // выводим среднее значение с точностью до одной десятой
}
Console.WriteLine(); // переводим строку для удобства чтения

// ждем, пока пользователь нажмет клавишу Enter, чтобы закрыть консольное окно
Console.ReadLine();
