// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()); // считываем количество строк
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()); // считываем количество столбцов

int[,] arr = new int[m, n]; // создаем двумерный массив

// заполняем массив числами от 1 до m*n
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = i * n + j + 1;
    }
}

// выводим массив на экран для проверки
Console.WriteLine("Массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{arr[i, j]}\t"); // выводим каждый элемент массива
    }
    Console.WriteLine(); // переводим строку после каждой строки массива
}

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()); // считываем номер строки
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()); // считываем номер столбца

if (row >= m || col >= n)
{
    Console.WriteLine("Ошибка: введенные позиции выходят за границы массива");
}
else
{
    int value = arr[row, col]; // получаем значение элемента
    Console.WriteLine($"Значение элемента: {value}");
}