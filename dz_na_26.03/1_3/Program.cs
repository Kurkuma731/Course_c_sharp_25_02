// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3

int[,] matrix1 = new int[,]
{
    { 2, 4 },
    { 3, 2 }
};

int[,] matrix2 = new int[,]
{
    { 3, 4 },
    { 3, 3 }
};

int rows1 = matrix1.GetLength(0);
int columns1 = matrix1.GetLength(1);

int rows2 = matrix2.GetLength(0);
int columns2 = matrix2.GetLength(1);

if (columns1 != rows2)
{
    Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй матрицы");
    return;
}

int[,] result = new int[rows1, columns2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        for (int k = 0; k < columns1; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}