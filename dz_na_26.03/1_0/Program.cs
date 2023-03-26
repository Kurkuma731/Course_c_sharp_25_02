// Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший 
//элемент массива.
int[,] array = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int minElement = array[0, 0];
int minRow = 0;
int minCol = 0;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            minRow = i;
            minCol = j;
        }
    }
}


int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
int newRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == minRow)
    {
        continue; 
    }

    int newCol = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == minCol)
        {
            continue; 
        }

        newArray[newRow, newCol] = array[i, j];
        newCol++;
    }

    newRow++;
}

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i, j] + " ");
    }
    Console.WriteLine();
}