﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

double[] arr = new double[5] { 2.4, 1.5, 4.7, 3.1, 2.8 }; // создаем массив из 5 вещественных чисел
double max = arr[0]; // переменная для максимального элемента
double min = arr[0]; // переменная для минимального элемента

// находим максимальный и минимальный элементы
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

// вычисляем разницу между максимальным и минимальным элементами
double diff = max - min;

// выводим результат
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
