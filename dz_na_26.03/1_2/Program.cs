// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] array = new int[,]
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int minSumRowIndex = 0;
int minSumRowSum = int.MaxValue;


for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }


    if (rowSum < minSumRowSum)
    {
        minSumRowIndex = i;
        minSumRowSum = rowSum;
    }
}

Console.WriteLine($"Наименьшая сумма элементов в строке {minSumRowIndex + 1}");